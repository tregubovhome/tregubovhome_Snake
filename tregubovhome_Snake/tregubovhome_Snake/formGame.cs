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
        //              0  1    2    3    4    5    6    7   8   9   10  11  12
        int[] delay = { 0, 300, 250, 200, 150, 125, 100, 80, 60, 50, 40, 35, 30 };
        int speed = 1;
        int score = 0;
        int collected = 0;
        Keys lastKey;
        public static Thread thrGamePlay;
        public formGame()
        {
            InitializeComponent();
            Statics.stngFormGame = this;
            this.label_Speed.Text = "Скорость № " + speed.ToString();
            this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
            this.label_score.Text = "0";
            this.label_collected.Text = "0";
            this.labelField.Enabled = false;
            this.buttonStart.Focus();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            thrGamePlay = new Thread(GamePlay);
            thrGamePlay.Name = "thrGamePlay";
            thrGamePlay.IsBackground = true;
            thrGamePlay.Start();
            this.buttonStart.Visible = false;
            this.Focus();
        }
        public void GamePlay()
        {
            trePoint p1 = new trePoint(3, 3, treType.BODY);
            treSnake snake = new treSnake(p1, 4, treDirection.RIGHT);
            Invoke(new dlgHelper(snake.Draw));
            treTargetCreate tc = new treTargetCreate();
            trePoint target = tc.Create();
            Invoke(new dlgHelper(target.Draw));
            while (true)
            {
                snake.Handle(lastKey);
                lastKey = Keys.None;
                trePoint collisWall = snake.CollisionWall();
                trePoint collisTail = snake.CollisionTail();
                if (collisWall != null)
                {
                    System.Media.SystemSounds.Hand.Play();
                    Invoke(new dlgHelper(collisWall.Draw));
                    Invoke(new dlgHelper(GameOver));
                    thrGamePlay.Abort();
                }
                else if (collisTail != null)
                {
                    System.Media.SystemSounds.Hand.Play();
                    Invoke(new dlgHelper(collisTail.Draw));
                    Invoke(new dlgHelper(GameOver));
                    thrGamePlay.Abort();
                }
                else if (snake.Eat(target))
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    Invoke(new dlgHelper(ScoreUpdate));
                    target = tc.Create();
                    Invoke(new dlgHelper(target.Draw));
                }
                else
                {
                    //System.Console.Beep(1200, 100);
                    //System.Media.SystemSounds.Hand.Play();
                    Invoke(new dlgHelper(snake.Move));
                }
                Thread.Sleep(delay[speed]);
            }
        }
        private void GameOver()
        {
            DialogResult res = MessageBox.Show("Пробуем ещё раз? :)", "АВАРИЯ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Statics.pList.Clear();
                while (this.Controls.Find("trePoint", true).Count() != 0)
                {
                    this.Controls.Remove(this.Controls.Find("trePoint", true)[0]);
                }
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.Name == "trePoint")
                    {
                        MessageBox.Show(ctr.Name);
                    }
                }
                lastKey = Keys.Right;
                speed = 1;
                this.label_Speed.Text = "Скорость № " + speed.ToString();
                score = -1;
                collected = -1;
                ScoreUpdate();
                this.buttonStart.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }
        private void ScoreUpdate()
        {
            score += speed;
            this.label_score.Text = score.ToString();
            collected++;
            this.label_collected.Text = collected.ToString();
            if (collected % 10 == 0 && speed < delay.Length - 1 && collected != 0)
            {
                speed++;
                this.label_Speed.Text = "Скорость № " + speed.ToString();
                this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
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
                    if (thrGamePlay != null)
                        thrGamePlay.Suspend();
                    if (MessageBox.Show("Выйти?", "Snake", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (thrGamePlay != null)
                            thrGamePlay.Resume();
                        Application.Exit();
                    }
                    else
                    {
                        if (thrGamePlay != null)
                            thrGamePlay.Resume();
                    }
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    if (speed < delay.Length - 1)
                    {
                        speed++;
                        this.label_Speed.Text = "Скорость № " + speed.ToString();
                        this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
                    }
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    if (speed > 1)
                    {
                        speed--;
                        this.label_Speed.Text = "Скорость № " + speed.ToString();
                        this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
                    }
                    break;
                case Keys.Pause:
                    if (thrGamePlay != null)
                    {
                        thrGamePlay.Suspend();
                        MessageBox.Show("           ПАУЗА\n\nOK - продолжить", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        thrGamePlay.Resume();
                    }
                    break;
                default:
                    lastKey = e.KeyCode;
                    break;
            }
            this.Focus();
        }
        private void formGame_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    lastKey = Keys.LButton;
                    break;
                case MouseButtons.Right:
                    lastKey = Keys.RButton;
                    break;
            }
        }
    }
}
