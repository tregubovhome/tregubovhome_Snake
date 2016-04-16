namespace tregubovhome_Snake
{
    partial class trePoint
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent(System.Windows.Forms.Control ctrlField, int x, int y, treType type)
        {
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 20);
            this.label.TabIndex = 0;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            if (type == treType.BODY)
            {
                this.label.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (type == treType.TARGET)
            {
                this.label.BackColor = System.Drawing.Color.Aqua;
            }
            else if (type == treType.POISON)
            {
                this.label.BackColor = System.Drawing.Color.Red;
            }
            // 
            // trePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Name = "trePoint";
            this.Size = new System.Drawing.Size(20, 20);
            this.Location = new System.Drawing.Point((x - 1) * 20 + ctrlField.Location.X, (y - 1) * 20 + ctrlField.Location.Y);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label;
    }
}
