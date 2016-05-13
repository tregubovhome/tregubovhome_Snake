﻿using System;
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
        //              0  1    2    3    4    5    6    7   8   9   10  11  12
        int[] delay = { 0, 300, 250, 200, 150, 125, 100, 80, 60, 50, 40, 35, 30 };
        int speed = 1;
        int score = 0;
        int collected = 0;
        public static Thread thrGamePlay;

        public formGame()
        {
            InitializeComponent();
            Statics.stngFormGame = this;
            this.ClientSize = new System.Drawing.Size(this.labelField.Width + this.labelField.Location.X * 2, this.labelField.Height + this.labelField.Location.Y + this.labelField.Location.X);
            this.label_Speed.Text = "Скорость № " + speed.ToString();
            this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
            this.label_score.Text = "";
            this.label_collected.Text = "";
            this.labelField.Enabled = false;
            this.buttonStart.Focus();
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
            trePoint p1 = new trePoint(3, 3, treType.BODY);
            treSnake snake = new treSnake(p1, 4, treDirection.RIGHT);
            Invoke(new dlgHelper(snake.Draw));

            treTargetCreate tc = new treTargetCreate();
            trePoint target = tc.Create();
            Invoke(new dlgHelper(target.Draw));

            while (true)
            {
                snake.Handle(lastKey);
                trePoint collis = snake.Collision();
                if (collis != null)
                {
                    Invoke(new dlgHelper(collis.Draw));

                    thrGamePlay.Abort();
                }
                else if (snake.Eat(target))
                {
                    Invoke(new dlgHelper(ScoreUpdate));
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
        private void ScoreUpdate()
        {
            score += speed;
            this.label_score.Text = score.ToString();
            collected++;
            this.label_collected.Text = collected.ToString();
            if (collected % 10 == 0 && speed < delay.Length - 1)
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
                    Application.Exit();
                    break;
                case Keys.Oemplus:
                    if (speed < delay.Length - 1)
                    {
                        speed++;
                        this.label_Speed.Text = "Скорость № " + speed.ToString();
                        this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
                    }
                    break;
                case Keys.OemMinus:
                    if (speed > 1)
                    {
                        speed--;
                        this.label_Speed.Text = "Скорость № " + speed.ToString();
                        this.label_delay.Text = "Задержка: " + delay[speed].ToString() + " мсек";
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
