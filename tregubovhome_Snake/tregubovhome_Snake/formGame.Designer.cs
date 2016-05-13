namespace tregubovhome_Snake
{
    partial class formGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelField = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label_Speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_delay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_collected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelField
            // 
            this.labelField.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelField.Location = new System.Drawing.Point(5, 120);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(642, 342);
            this.labelField.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(272, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 110);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.BackColor = System.Drawing.Color.Transparent;
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Speed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Speed.Location = new System.Drawing.Point(12, 8);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(181, 29);
            this.label_Speed.TabIndex = 2;
            this.label_Speed.Text = "Скорость № 1";
            this.label_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(401, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Powered by Alex Tregubov\r\nAT Technologies, LLC, 2016";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label_delay
            // 
            this.label_delay.AutoSize = true;
            this.label_delay.BackColor = System.Drawing.Color.Transparent;
            this.label_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_delay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_delay.Location = new System.Drawing.Point(13, 37);
            this.label_delay.Name = "label_delay";
            this.label_delay.Size = new System.Drawing.Size(173, 20);
            this.label_delay.TabIndex = 2;
            this.label_delay.Text = "задержка: 300 мсек";
            this.label_delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Очки:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_score.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_score.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_score.Location = new System.Drawing.Point(124, 61);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(69, 29);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "8888";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Собрано:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_collected
            // 
            this.label_collected.AutoSize = true;
            this.label_collected.BackColor = System.Drawing.Color.Transparent;
            this.label_collected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_collected.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_collected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_collected.Location = new System.Drawing.Point(124, 90);
            this.label_collected.Name = "label_collected";
            this.label_collected.Size = new System.Drawing.Size(69, 29);
            this.label_collected.TabIndex = 2;
            this.label_collected.Text = "8888";
            this.label_collected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(649, 464);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.label_delay);
            this.Controls.Add(this.label_collected);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Speed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "formGame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_collected;
    }
}