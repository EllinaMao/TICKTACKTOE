using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;


namespace TickTackToes
{
    public partial class TickTackToe : Form
    {
        //флаги
        private bool isXTurn; // чей ход
        readonly bool forAI; // храним флаг что бы знать что ход ИИ
        readonly bool isSoloGame;
        private bool isGameWon = false;

        //логика игры
        private GameLogic gameLogic;

        
        public TickTackToe(bool GameChoice)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            int randomNumber = new Random().Next(0, 2); // верхняя не включительно
            isXTurn = Convert.ToBoolean(randomNumber);
            forAI = !isXTurn;
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += TickTackToe_KeyDown;
            this.FormClosing += ExitButton_Click;

            isSoloGame = GameChoice; // true - соло, false - мультиплеер(локальный!!!)
            gameLogic = new GameLogic();
            InteractionUI.ShowPlayerTurn(isXTurn);
        }

        //два метода для выхода из игры, потому что она постоянно крашилась
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
        //при нажатии на кнопку идет обработка чей ход идет, при необходимости ход ИИ
        private void MyButton_Click(object sender, EventArgs e)
        {
            if (isGameWon)
            {             
                return;
            }

            if (sender is not Button btn || !string.IsNullOrEmpty(btn.Text))
            {
                return;
            }

            int row = tableLayoutPanel2.GetRow(btn);
            int col = tableLayoutPanel2.GetColumn(btn);

            Player(btn, row, col);

            // Ход ИИ
            if (isSoloGame && isXTurn == forAI)
            {
                SoloGameAi();
            }

            GameOver(); 
        }

        // обработка хода игрока
        void Player(Button btn, int row, int col)
        {
            // Ход игрока
            string playerSymbol = isXTurn ? "X" : "O";
            btn.Text = playerSymbol;
            btn.Enabled = false;
            gameLogic.MakeMove(row, col, playerSymbol);
            isXTurn = !isXTurn;
            //InteractionUI.ShowPlayerTurn(isXTurn);
        }
        //обработка хода ИИ
        void SoloGameAi()
        {
            if (isSoloGame && !isGameWon)
            {
                var aiLogic = new AILogic(gameLogic, isXTurn);
                var move = aiLogic.FindBestMove();
                if (move != null)
                {
                    foreach (Control c in tableLayoutPanel2.Controls)
                    {
                        if (c is Button ai &&
                            tableLayoutPanel2.GetRow(ai) == move.Value.row &&
                            tableLayoutPanel2.GetColumn(ai) == move.Value.col)
                        {
                            ai.Text = isXTurn ? "X" : "O";
                            ai.Enabled = false;
                            gameLogic.MakeMove(move.Value.row, move.Value.col, ai.Text);
                            break;
                        }
                    }
                }
            }
            isXTurn = !isXTurn;
            //InteractionUI.ShowPlayerTurn(isXTurn);
        }

        private void GameOver()
        {
            if (gameLogic.CheckWin())
            {
                isGameWon = true;
                InteractionUI.ShowWin(!isXTurn);
                isGameWon = true;

            }
            else if (gameLogic.CheckDraw())
            {
                isGameWon = true;
                InteractionUI.ShowDraw();

            }

            if (isGameWon)
            {
                Application.Restart();
            }

        }
    }
}
