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
    public delegate void dlgHelper();
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
            Thread thrGamePlay = new Thread(GamePlay);
            thrGamePlay.Name = "thrGamePlay";
            thrGamePlay.Start();
            //Thread.Sleep(900);
            //newDirection = treDirection.DOWN;
        }
        public void GamePlay()
        {
            trePoint p2 = new trePoint(10, 10, treType.TARGET);
            dlgHelper helper = new dlgHelper(p2.Draw);
            Invoke(helper);
            trePoint p1 = new trePoint(3, 3, treType.BODY);
            treSnake snake = new treSnake(p1, 4, treDirection.RIGHT);
            snake.Draw();
            newDirection = snake.direction;
            int i = 0;
            while (i<7)//(true)
            {
                /*if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = treDirection.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = treDirection.RIGHT;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = treDirection.UP;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = treDirection.DOWN;
                }*/
                snake.direction = newDirection;
                Thread.Sleep(300);
                snake.Move();
                i++;
            }
        }          
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
    }
}
