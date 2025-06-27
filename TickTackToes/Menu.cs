using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Включить двойную буферизацию
            ShowMenu();
        }

        public void ShowMenu()
        {
            this.Text = "Меню";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Properties.Resources._8339bec72f606bb96256b486fe867580; // Установка фонового изображения

        }

        private void SoloGameClick(object sender, EventArgs e)
        {
            this.Hide();
            TickTackToe game = new TickTackToe(true);
            game.ShowDialog();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Завершение приложения
        }

        private void StartMultiplayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            TickTackToe game = new TickTackToe(false);
            game.ShowDialog();

        }
    }
}
