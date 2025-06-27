using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace TickTackToes
{
    public partial class TickTackToe : Form
    {
        //flags
        private bool isXTurn; // Track whose turn it is
        private bool forAI;
        private bool isSoloGame;
        private bool isGameWon = false;

        // Add a GameLogic instance
        private GameLogic gameLogic;

        //constructors
        public TickTackToe(bool GameChoice)
        {
            int randomNumber = new Random().Next(0, 2); // верхняя не включительно
            isXTurn = Convert.ToBoolean(randomNumber);
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += TickTackToe_KeyDown;
            this.FormClosing += ExitButton_Click;

            isSoloGame = GameChoice; // true - solo game, false - multiplayer

            // Initialize the GameLogic instance
            gameLogic = new GameLogic();
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

        //private void MyButton_Click(object sender, EventArgs e)
        //{
        //    Button? btn = sender as Button;
        //    if (btn == null || !string.IsNullOrEmpty(btn.Text))
        //    {
        //        return;
        //    }

        //    btn.Text = isXTurn ? "X" : "O";
        //    btn.Enabled = false;
        //    InteractionUI.ShowPlayerTurn(isXTurn);

        //    gameBoard[tableLayoutPanel2.GetRow(btn), tableLayoutPanel2.GetColumn(btn)] = btn.Text;

        //    isXTurn = !isXTurn;
        //}

        private void MyButton_Click(object sender, EventArgs e)
        {
            if (isGameWon) return;

            Button? btn = sender as Button;
            if (btn == null || !string.IsNullOrEmpty(btn.Text))
                return;

            int row = tableLayoutPanel2.GetRow(btn);
            int col = tableLayoutPanel2.GetColumn(btn);

            Player(btn, row, col);

            // Ход ИИ (если solo game)
            if (isSoloGame && !isGameWon)
            {
                var aiLogic = new AILogic(gameLogic, isXTurn);
                var move = aiLogic.FindBestMove();
                if (move != null)
                {
                    // Найти соответствующую кнопку по координатам
                    foreach (Control c in tableLayoutPanel2.Controls)
                    {
                        if (c is Button aiBtn &&
                            tableLayoutPanel2.GetRow(aiBtn) == move.Value.row &&
                            tableLayoutPanel2.GetColumn(aiBtn) == move.Value.col)
                        {
                            aiBtn.Text = isXTurn ? "X" : "O";
                            aiBtn.Enabled = false;
                            gameLogic.MakeMove(move.Value.row, move.Value.col, aiBtn.Text);
                            break;
                        }
                    }

                    if (gameLogic.CheckWin())
                    {
                        isGameWon = true;
                        InteractionUI.ShowWin(isXTurn);
                        
                        return;
                    }
                    if (gameLogic.CheckDraw())
                    {
                        isGameWon = true;
                        InteractionUI.ShowDraw();
                        
                        return;
                    }

                    isXTurn = !isXTurn;
                    InteractionUI.ShowPlayerTurn(isXTurn);
                }
            }
        }



        


        void Player(Button btn,int row, int col )
        {
            // Ход игрока
            string playerSymbol = isXTurn ? "X" : "O";
            btn.Text = playerSymbol;
            btn.Enabled = false;
            gameLogic.MakeMove(row, col, playerSymbol);

            if (gameLogic.CheckWin())
            {
                isGameWon = true;
                InteractionUI.ShowWin(isXTurn);
                return;
            }
            if (gameLogic.CheckDraw())
            {
                isGameWon = true;
                InteractionUI.ShowDraw();
                return;
            }

            isXTurn = !isXTurn;
            InteractionUI.ShowPlayerTurn(isXTurn);

        }











    }
}
