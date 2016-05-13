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
            this.SuspendLayout();
            // 
            // labelField
            // 
            this.labelField.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelField.Location = new System.Drawing.Point(12, 100);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(643, 343);
            this.labelField.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(318, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 76);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label_Speed
            // 
            this.label_Speed.BackColor = System.Drawing.Color.Transparent;
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Speed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Speed.Location = new System.Drawing.Point(12, 12);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(418, 76);
            this.label_Speed.TabIndex = 2;
            this.label_Speed.Text = "Скорость №1\r\nЗадержка: 300 мсек";
            this.label_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(424, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Powered by Alex Tregubov\r\nAT Technologies, LLC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(667, 455);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelField);
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
    }
}