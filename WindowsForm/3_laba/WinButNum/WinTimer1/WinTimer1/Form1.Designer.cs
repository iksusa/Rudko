namespace WinTimer1
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
			this.userControlTimer1 = new WinTimer1.UserControlTimer();
			this.SuspendLayout();
			// 
			// userControlTimer1
			// 
			this.userControlTimer1.Location = new System.Drawing.Point(39, 22);
			this.userControlTimer1.Margin = new System.Windows.Forms.Padding(1);
			this.userControlTimer1.Name = "userControlTimer1";
			this.userControlTimer1.Size = new System.Drawing.Size(175, 92);
			this.userControlTimer1.TabIndex = 0;
			this.userControlTimer1.TimeEnabled = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 140);
			this.Controls.Add(this.userControlTimer1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer1;
    }
}

