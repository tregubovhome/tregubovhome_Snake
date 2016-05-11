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
        Char lastKey;
        public static int mapSizeX = 32;
        public static int mapSizeY = 17;
        public formGame()
        {
            tregubovhome_Snake.Program.stngFormGame = this;
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Thread thrGamePlay = new Thread(GamePlay);
            thrGamePlay.Name = "thrGamePlay";
            thrGamePlay.IsBackground = true;
            thrGamePlay.Start();
        }
        public void GamePlay()
        {
            //trePoint target = new trePoint(10, 10, treType.TARGET);
            //Invoke(new dlgHelper(target.Draw));

            treTargetCreate tc = new treTargetCreate();
            trePoint target = tc.Create();
            Invoke(new dlgHelper(target.Draw)); 
            
            trePoint p1 = new trePoint(3, 3, treType.BODY);
            treSnake snake = new treSnake(p1, 4, treDirection.RIGHT);
            Invoke(new dlgHelper(snake.Draw));
            int i = 0;
            while (true)
            {
                snake.Handle(lastKey);
                if (snake.Eat(target))
                {
                    target = tc.Create();
                    Invoke(new dlgHelper(target.Draw)); 
                }
                else
                {
                    Invoke(new dlgHelper(snake.Move));
                }
                Thread.Sleep(200);
                i++;
            }
        }
        private void formGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            lastKey = e.KeyChar;
        }
    }
}
