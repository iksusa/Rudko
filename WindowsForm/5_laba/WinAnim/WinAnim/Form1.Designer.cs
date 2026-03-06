namespace WinAnim
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
			this.btnAW_BLEND = new System.Windows.Forms.Button();
			this.btnHOR_AW_SLIDE = new System.Windows.Forms.Button();
			this.btnCentre_AW_SLIDE = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAW_BLEND
			// 
			this.btnAW_BLEND.Location = new System.Drawing.Point(20, 40);
			this.btnAW_BLEND.Margin = new System.Windows.Forms.Padding(2);
			this.btnAW_BLEND.Name = "btnAW_BLEND";
			this.btnAW_BLEND.Size = new System.Drawing.Size(155, 121);
			this.btnAW_BLEND.TabIndex = 0;
			this.btnAW_BLEND.Text = "проявление";
			this.btnAW_BLEND.UseVisualStyleBackColor = true;
			this.btnAW_BLEND.Click += new System.EventHandler(this.btnAW_BLEND_Click);
			// 
			// btnHOR_AW_SLIDE
			// 
			this.btnHOR_AW_SLIDE.Location = new System.Drawing.Point(193, 39);
			this.btnHOR_AW_SLIDE.Margin = new System.Windows.Forms.Padding(2);
			this.btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
			this.btnHOR_AW_SLIDE.Size = new System.Drawing.Size(155, 122);
			this.btnHOR_AW_SLIDE.TabIndex = 1;
			this.btnHOR_AW_SLIDE.Text = "горизантальное проявление";
			this.btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
			this.btnHOR_AW_SLIDE.Click += new System.EventHandler(this.btnHOR_AW_SLIDE_Click);
			// 
			// btnCentre_AW_SLIDE
			// 
			this.btnCentre_AW_SLIDE.Location = new System.Drawing.Point(367, 39);
			this.btnCentre_AW_SLIDE.Margin = new System.Windows.Forms.Padding(2);
			this.btnCentre_AW_SLIDE.Name = "btnCentre_AW_SLIDE";
			this.btnCentre_AW_SLIDE.Size = new System.Drawing.Size(155, 122);
			this.btnCentre_AW_SLIDE.TabIndex = 2;
			this.btnCentre_AW_SLIDE.Text = "появление из центра";
			this.btnCentre_AW_SLIDE.UseVisualStyleBackColor = true;
			this.btnCentre_AW_SLIDE.Click += new System.EventHandler(this.btnCentre_AW_SLIDE_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 292);
			this.Controls.Add(this.btnCentre_AW_SLIDE);
			this.Controls.Add(this.btnHOR_AW_SLIDE);
			this.Controls.Add(this.btnAW_BLEND);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "анимация формы";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAW_BLEND;
        private System.Windows.Forms.Button btnHOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCentre_AW_SLIDE;
    }
}

