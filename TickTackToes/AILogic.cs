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
        private readonly char aiSymbol;
        private readonly char playerSymbol;

        AILogic(GameLogic logic, bool symbol)
        {
            
            this.logic = logic;
            aiSymbol = symbol ? 'X' : 'O';
            playerSymbol = symbol ? 'O' : 'X';
        }
        private (int row, int col)? CanAIWin(char AISymbol)
        {
            for (int row = 0; row < 3; row++)
            {
                var winMove = FindRowWin(row, AISymbol);
                if (winMove != null)
                    return winMove;
            }
            return null;
        }
        public (int row, int col)? BlockPlayer()
        {
            for (int row = 0; row < 3; row++)
            {
                var blockMove = FindRowWin(row, playerSymbol);
                if (blockMove != null)
                    return blockMove;
            }
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











    }
}
