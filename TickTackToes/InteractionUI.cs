using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToes
{
    internal class InteractionUI
    {
        public static void ShowPlayerTurn(bool isX)
        {
            MessageBox.Show($"Вы: {(isX ? "X" : "O")}", "Ход", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWin(bool isX)
        {
            MessageBox.Show($"{(isX ? "X" : "O")} победил!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDraw()
        {
            MessageBox.Show("Ничья!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
