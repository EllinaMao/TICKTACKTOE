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



        private void MultiplayerLogic()
        {


        }

        private void SoloGameLogic()
        {
            AILogic aiLogic = new AILogic(gameLogic, isXTurn);
            // AI's turn
            (int row, int col)? aiMove = aiLogic.CanAIWin(aiLogic.aiSymbol);
            if (aiMove == null)
            {
                aiMove = aiLogic.BlockPlayer();
            }
            if (aiMove == null)
            {
                // If no winning or blocking move, choose a random empty cell
                aiMove = gameLogic.GetRandomEmptyCell();
            }
            if (aiMove != null)
            {
                gameLogic.MakeMove(aiMove.Value.row, aiMove.Value.col, aiLogic.aiSymbol);
                isXTurn = !isXTurn;
                InteractionUI.ShowPlayerTurn(isXTurn);
            }

        }
}
