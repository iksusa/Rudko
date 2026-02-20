namespace TestList
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSort = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.peopleList = new System.Windows.Forms.ComboBox();
			this.memberList = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(57, 31);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(97, 76);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Список участников";
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(367, 238);
			this.buttonSort.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(101, 29);
			this.buttonSort.TabIndex = 11;
			this.buttonSort.Text = "Сортировать";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(367, 191);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(101, 29);
			this.buttonDelete.TabIndex = 10;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(367, 147);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(101, 29);
			this.buttonAdd.TabIndex = 9;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// peopleList
			// 
			this.peopleList.FormattingEnabled = true;
			this.peopleList.Items.AddRange(new object[] {
            "Анджела",
            "Ксюха",
            "ВерОника",
            "Софiйко",
            "Грибочек",
            "Надюха",
            "Настюха",
            "Регина Майонез",
            "ПИГОРЕВА",
            ""});
			this.peopleList.Location = new System.Drawing.Point(353, 31);
			this.peopleList.Margin = new System.Windows.Forms.Padding(2);
			this.peopleList.Name = "peopleList";
			this.peopleList.Size = new System.Drawing.Size(115, 21);
			this.peopleList.TabIndex = 8;
			this.peopleList.SelectedIndexChanged += new System.EventHandler(this.peopleList_SelectedIndexChanged);
			// 
			// memberList
			// 
			this.memberList.FormattingEnabled = true;
			this.memberList.Location = new System.Drawing.Point(194, 30);
			this.memberList.Margin = new System.Windows.Forms.Padding(2);
			this.memberList.Name = "memberList";
			this.memberList.Size = new System.Drawing.Size(118, 79);
			this.memberList.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSort);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.peopleList);
			this.Controls.Add(this.memberList);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox peopleList;
        private System.Windows.Forms.CheckedListBox memberList;
    }
}

