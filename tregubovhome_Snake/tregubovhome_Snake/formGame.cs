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
        Keys lastKey;
        int[] delay = { 300, 250, 200, 150, 125, 100, 80, 60, 50, 40, 35, 30 };
        int speed = 0;
        public static Thread thrGamePlay;

        public formGame()
        {
            InitializeComponent();
            Statics.stngFormGame = this;
            this.labelField.Location = new Point(5, 100);
            this.labelField.Size = new System.Drawing.Size(Statics.mapSizeX * 20 + 2, Statics.mapSizeY * 20 + 2);
            this.ClientSize = new System.Drawing.Size(this.labelField.Width + this.labelField.Location.X * 2, this.labelField.Height + this.labelField.Location.Y + this.labelField.Location.X);
            this.label_Speed.Text = "Скорость № " + speed.ToString() + "\nЗадержка: " + delay[speed].ToString() + " мсек";
            this.labelField.Enabled = false;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            thrGamePlay = new Thread(GamePlay);
            thrGamePlay.Name = "thrGamePlay";
            thrGamePlay.IsBackground = true;
            thrGamePlay.Start();
            ((Button)Statics.stngFormGame.Controls.Find("buttonStart", true).First()).Visible = false;
            this.Focus();
        }
        public void GamePlay()
        {
            treTargetCreate tc = new treTargetCreate();
            trePoint target = tc.Create();
            Invoke(new dlgHelper(target.Draw));

            trePoint p1 = new trePoint(3, 3, treType.BODY);
            treSnake snake = new treSnake(p1, 4, treDirection.RIGHT);
            Invoke(new dlgHelper(snake.Draw));
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
                Thread.Sleep(delay[speed]);
            }
        }
        private void formGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thrGamePlay != null) thrGamePlay.Abort();
        }
        private void formGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    //this.Close();
                    break;
                case Keys.Oemplus:
                    if (speed < delay.Length - 1)
                    {
                        speed++;
                        this.label_Speed.Text = "Скорость № " + speed.ToString() + "\nЗадержка: " + delay[speed].ToString() + " мсек";
                    }
                    break;
                case Keys.OemMinus:
                    if (speed > 0)
                    {
                        speed--;
                        this.label_Speed.Text = "Скорость № " + speed.ToString() + "\nЗадержка: " + delay[speed].ToString() + " мсек";
                    }
                    break;
                default:
                    lastKey = e.KeyCode;
                    break;
            }
            this.Focus();
        }
    }
}
