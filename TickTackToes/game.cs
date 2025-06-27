using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;


namespace TickTackToes
{
    public partial class TickTackToe : Form
    {
        //флаги
        private bool isXTurn; // чей ход
        private bool forAI; // храним флаг что бы знать что ход ИИ
        readonly bool isSoloGame;
        private bool isGameWon = false;

        //логика игры
        private GameLogic gameLogic;

        
        public TickTackToe(bool GameChoice)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            isSoloGame = GameChoice; // true - соло, false - мультиплеер(локальный!!!)
            this.KeyPreview = true;
            this.KeyDown += TickTackToe_KeyDown;
            this.FormClosing += ExitMetod;
            gameLogic = new GameLogic();
            isXTurn = true;
            InitializeComponent();
            LoadProperties();
        }

        private void TickTackToe_Load(object? sender, EventArgs e)
        {
            if (isSoloGame && isXTurn == forAI)
            {
                InteractionUI.ShowPlayerTurn(!forAI);
                SoloGameAi();
            }
        }
        //при нажатии на кнопку выхода - приложение перезапускается
        private void ExitButton_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }
        private void ExitMetod(object? sender, EventArgs e)
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
        }


        // обработка хода игрока
        void Player(Button btn, int row, int col)
        {
            // Ход игрока
            string playerSymbol = isXTurn ? "X" : "O";
            btn.Text = playerSymbol;
            btn.Enabled = false;
            gameLogic.MakeMove(row, col, playerSymbol);
            GameOver();
            isXTurn = !isXTurn;
        }
        //обработка хода ИИ
        void SoloGameAi()
        {
            if (isSoloGame && !isGameWon)
            {
                var aiLogic = new AILogic(gameLogic, forAI);
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
            GameOver();
            isXTurn = !isXTurn;
        }

        private void GameOver()
        {
            if (gameLogic.CheckWin())
            {
                isGameWon = true;
                InteractionUI.ShowWin(isXTurn);
                isGameWon = true;

            }
            else if (gameLogic.CheckDraw())
            {
                isGameWon = true;
                InteractionUI.ShowDraw();

            }

            if (isGameWon)
            {
                ResetGame();
            }

        }
        private void ResetGame()
        {
            gameLogic.Reset();
            isGameWon = false;
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                if (c is Button btn)
                {
                    btn.Text = string.Empty;
                    btn.Enabled = true;
                }
            }

            if (isSoloGame)
            {

                isXTurn = true;
                int randomNumber = new Random().Next(0, 2);
                forAI = Convert.ToBoolean(randomNumber);
                InteractionUI.ShowPlayerTurn(!forAI);
                if (isXTurn == forAI) { 
                SoloGameAi();
                }

            }
        }

        private void LoadProperties()
        {
            if (!isSoloGame)
            {
                return;
            }
            int randomNumber = new Random().Next(0, 2);
            forAI = Convert.ToBoolean(randomNumber);
            this.Load += TickTackToe_Load;
        }
    }
}
