namespace WinTimer2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.userControlTimer21 = new WinTimer2.UserControlTimer2();
			this.SuspendLayout();
			// 
			// userControlTimer21
			// 
			this.userControlTimer21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.userControlTimer21.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userControlTimer21.Location = new System.Drawing.Point(40, 39);
			this.userControlTimer21.Margin = new System.Windows.Forms.Padding(1);
			this.userControlTimer21.Name = "userControlTimer21";
			this.userControlTimer21.Size = new System.Drawing.Size(437, 133);
			this.userControlTimer21.TabIndex = 0;
			this.userControlTimer21.Load += new System.EventHandler(this.userControlTimer21_Load);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.userControlTimer21);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer2 userControlTimer21;
    }
}

