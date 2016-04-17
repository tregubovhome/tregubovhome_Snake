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
        treDirection newDirection;
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
            newDirection = snake.direction;
            while (true)
            { 
                snake.direction = newDirection;
                snake.Move();
                Thread.Sleep(300);
            }
        }

        /*protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Left)
            { newDirection = treDirection.LEFT; }
            else if (e.KeyCode == Keys.Right)
            { newDirection = treDirection.RIGHT; }
            else if (e.KeyCode == Keys.Up)
            { newDirection = treDirection.UP; }
            else if (e.KeyCode == Keys.Down)
            { newDirection = treDirection.DOWN; }
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                MessageBox.Show("Тест");
            }
            e.Handled = true;
            MessageBox.Show("OnKeyDown");
        }*/
        private void formGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToLower() == "a" || e.KeyChar.ToString().ToLower() == "ф")//Keys.Left.ToString())
            { newDirection = treDirection.LEFT; }
            else if (e.KeyChar.ToString().ToLower() == "d" || e.KeyChar.ToString().ToLower() == "в") //Keys.Right.ToString())
            { newDirection = treDirection.RIGHT; }
            else if (e.KeyChar.ToString().ToLower() == "w" || e.KeyChar.ToString().ToLower() == "ц") //Keys.Up.ToString())
            { newDirection = treDirection.UP; }
            else if (e.KeyChar.ToString().ToLower() == "s" || e.KeyChar.ToString().ToLower() == "ы") //Keys.Down.ToString())
            { newDirection = treDirection.DOWN; }
            MessageBox.Show("formGame_KeyPress");
        }

        /*private void formGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            { newDirection = treDirection.LEFT; }
            else if (e.KeyCode == Keys.Right)
            { newDirection = treDirection.RIGHT; }
            else if (e.KeyCode == Keys.Up)
            { newDirection = treDirection.UP; }
            else if (e.KeyCode == Keys.Down)
            { newDirection = treDirection.DOWN; }
        }*/
    }
}
