using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToes
{
    internal class AILogic
    {
        private readonly GameLogic logic;
        public readonly char aiSymbol;
        public readonly char playerSymbol;

        AILogic(GameLogic logic, bool symbol)
        {
            
            this.logic = logic;
            aiSymbol = symbol ? 'X' : 'O';
            playerSymbol = symbol ? 'O' : 'X';
        }
        private (int row, int col)? CanAIWin(char AISymbol)
        {
            // Проверка строк
            for (int row = 0; row < 3; row++)
            {
                var winMove = FindRowWin(row, AISymbol);
                if (winMove != null)
                    return winMove;
            }
            // Проверка столбцов
            for (int col = 0; col < 3; col++)
            {
                var winMove = FindColWin(col, AISymbol);
                if (winMove != null)
                    return winMove;
            }
            // Проверка главной диагонали
            var mainDiagWin = FindMainDiagonalWin(AISymbol);
            if (mainDiagWin != null)
                return mainDiagWin;
            // Проверка побочной диагонали
            var antiDiagWin = FindAntiDiagonalWin(AISymbol);
            if (antiDiagWin != null)
                return antiDiagWin;

            return null;
        }

        public (int row, int col)? BlockPlayer()
        {
            // Проверка строк
            for (int row = 0; row < 3; row++)
            {
                var blockMove = FindRowWin(row, playerSymbol);
                if (blockMove != null)
                    return blockMove;
            }
            // Проверка столбцов
            for (int col = 0; col < 3; col++)
            {
                var blockMove = FindColWin(col, playerSymbol);
                if (blockMove != null)
                    return blockMove;
            }
            // Проверка главной диагонали
            var mainDiagBlock = FindMainDiagonalWin(playerSymbol);
            if (mainDiagBlock != null)
                return mainDiagBlock;
            // Проверка побочной диагонали
            var antiDiagBlock = FindAntiDiagonalWin(playerSymbol);
            if (antiDiagBlock != null)
                return antiDiagBlock;

            return null;
        }

        public (int row, int col)? FindBestMove()
        {
            // 1. Попробовать выиграть
            var aiWin = CanAIWin(aiSymbol);
            if (aiWin != null) { return aiWin; }

            // 2. Заблокировать игрока
            var blockPlayer = BlockPlayer();
            if (blockPlayer != null) { return blockPlayer; }

            // 3. Занять центр
            if (string.IsNullOrEmpty(logic.GameBoard[1, 1])) { 
                return (1, 1);
            }

            var corners = new (int, int)[] { (0, 0), (0, 2), (2, 0), (2, 2) };
            foreach (var (row, col) in corners)
                if (string.IsNullOrEmpty(logic.GameBoard[row, col])) { 
                    return (row, col);
                }

            var sides = new (int, int)[] { (0, 1), (1, 0), (1, 2), (2, 1) };
            foreach (var (row, col) in sides)
                if (string.IsNullOrEmpty(logic.GameBoard[row, col]))
                { return (row, col); }

            return null;
        }
        private (int row, int col)? FindColWin(int col, char symbol)
        {
            int count = 0, emptyRow = -1;
            for (int row = 0; row < 3; row++)
            {
                if (logic.GameBoard[row, col] == symbol.ToString()) count++;
                else if (string.IsNullOrEmpty(logic.GameBoard[row, col])) emptyRow = row;
            }
            return (count == 2 && emptyRow != -1) ? (emptyRow, col) : null;
        }

        //helpers for finding winning moves

        private (int row, int col)? FindRowWin(int row, char symbol)
        {
            int count = 0, emptyCol = -1;
            for (int col = 0; col < 3; col++)
            {
                if (logic.GameBoard[row, col] == symbol.ToString()) count++;
                else if (string.IsNullOrEmpty(logic.GameBoard[row, col])) emptyCol = col;
            }
            return (count == 2 && emptyCol != -1) ? (row, emptyCol) : null;
        }

        private (int row, int col)? FindMainDiagonalWin(char symbol)
        {
            int count = 0, empty = -1;
            for (int i = 0; i < 3; i++)
            {
                if (logic.GameBoard[i, i] == symbol.ToString()) count++;
                else if (string.IsNullOrEmpty(logic.GameBoard[i, i])) empty = i;
            }
            return (count == 2 && empty != -1) ? (empty, empty) : null;
        }

        private (int row, int col)? FindAntiDiagonalWin(char symbol)
        {
            int count = 0, empty = -1;
            for (int i = 0; i < 3; i++)
            {
                if (logic.GameBoard[i, 2 - i] == symbol.ToString()) count++;
                else if (string.IsNullOrEmpty(logic.GameBoard[i, 2 - i])) empty = i;
            }
            return (count == 2 && empty != -1) ? (empty, 2 - empty) : null;
        }











    }
}
