using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{
    public partial class formGame : Form
    {
        public formGame()
        {
            tregubovhome_Snake.Program.stngFormGame = this;
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            trePoint p2 = new trePoint(10, 10, treType.TARGET);
            p2.Draw();
            trePoint p1 = new trePoint(3, 3, treType.BODY);
            treSnake snake = new treSnake(p1, 4, treDirection.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300);
        }
    }
}
