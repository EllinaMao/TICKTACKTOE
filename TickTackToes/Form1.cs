using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;

namespace TickTackToes
{
    public partial class TickTackToe : Form
    {

        private Button[,] MyButtons;
        bool isXTurn; // Track whose turn it is
        private int movesCount = 0;


        public TickTackToe(bool GameChoice)
        {
            int randomNumber = new Random().Next(0, 1);
            isXTurn = Convert.ToBoolean(randomNumber);
            InitializeBoard();
            InitializeButton();

            if (GameChoice)
            {
                this.Text = "Solo Game";

            }
            else
            {
                // Multiplayer game
                this.Text = "Multiplayer Game";

            }


        }   


        private void InitializeButton()
        {
            MyButtons = new Button[3, 3];
            int buttonSize = 100; // Размер кнопки


        }


        private void InitializeBoard()
        {
            this.Text = "Хрестики-нолики";
            this.Width = 350;
            this.Height = 370;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.CornflowerBlue; // Цвет фона формы
            Application.Exit();

        }
        private void MyButton_Click(object sender, EventArgs e)
        {
            //myButton.Text = (isXTurn ? "X" : "O");
            //isXTurn = !isXTurn; 
            //myButton.Enabled = false;
        }



    }
}

    
