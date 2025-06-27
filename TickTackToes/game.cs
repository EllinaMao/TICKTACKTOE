using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace TickTackToes
{
    public partial class TickTackToe : Form
    {
        //flags
        private bool isXTurn; // Track whose turn it is
        private bool isSoloGame;
        private bool isGameWon = false;

        //constructors
        public TickTackToe(bool GameChoice)
        {
            int randomNumber = new Random().Next(0, 2); // верхняя не включительно
            isXTurn = Convert.ToBoolean(randomNumber);

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += TickTackToe_KeyDown;
            this.FormClosing += ExitButton_Click;

     
            isSoloGame = GameChoice;//true - solo game, false - multiplayer

        }
        private void ExitButton_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TickTackToe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn == null || !string.IsNullOrEmpty(btn.Text))
            {
                return;
            }

            btn.Text = isXTurn ? "X" : "O";
            btn.Enabled = false;
            movesCount++;
            gameBoard[tableLayoutPanel2.GetRow(btn), tableLayoutPanel2.GetColumn(btn)] = btn.Text;

            isXTurn = !isXTurn;
        }
        
        private void AIMove(int row, int emptyCol, char symbol)
        {
            
        }
        private bool TryCompleteRow(string simbol)
        {
            int count, emptyCol;
            for (int row = 0; row < 3; row++)
            {
                count = 0; emptyCol = -1;
                for (int col = 0; col<3; col++)
                {
                    if (gameBoard[row, col] == simbol)
                    {
                        count++;
                    }
                    else if (string.IsNullOrEmpty(gameBoard[row, col]))
                    { 
                        emptyCol = col;
                    }
                }
            }
            return false;

        }
        




    }
}
