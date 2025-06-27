using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToes
{

    public class GameLogic
    {
        public string[,] GameBoard { get; private set; }
        public int MovesCount { get; private set; }

        public GameLogic()
        {
            GameBoard = new string[3, 3];
            Reset();
        }

        public void Reset()
        {
            MovesCount = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    GameBoard[row, col] = string.Empty;
                }
            }
        }

        public void MakeMove(int row, int col, string symbol)
        {
            if (string.IsNullOrEmpty(GameBoard[row, col]))
            {
                GameBoard[row, col] = symbol;
                MovesCount++;
            }
        }

        public bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(GameBoard[i, 0]) &&
                    GameBoard[i, 0] == GameBoard[i, 1] && GameBoard[i, 1] == GameBoard[i, 2])
                {
                    return true;
                }

                if (!string.IsNullOrEmpty(GameBoard[0, i]) &&
                    GameBoard[0, i] == GameBoard[1, i] && GameBoard[1, i] == GameBoard[2, i])
                {
                    return true;
                }
            }

            if (!string.IsNullOrEmpty(GameBoard[0, 0]) &&
                GameBoard[0, 0] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 2])
            {
                return true;
            }

            if (!string.IsNullOrEmpty(GameBoard[0, 2]) &&
                GameBoard[0, 2] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 0])
            {
                return true;
            }

            return false;
        }

        public bool CheckDraw()
        {
            return MovesCount == 9 && !CheckWin();
        }
    } 
    
}
