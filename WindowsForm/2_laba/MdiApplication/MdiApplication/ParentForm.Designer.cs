namespace MdiApplication
{
    partial class ParentForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.spWin = new System.Windows.Forms.ToolStripStatusLabel();
			this.spData = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.WindowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WindowTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.WindowMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.WindowMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(285, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "MdiMenu";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.ExitMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(37, 22);
			this.FileMenuItem.Text = "&File";
			// 
			// NewMenuItem
			// 
			this.NewMenuItem.Name = "NewMenuItem";
			this.NewMenuItem.Size = new System.Drawing.Size(98, 22);
			this.NewMenuItem.Text = "&New";
			this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.Size = new System.Drawing.Size(98, 22);
			this.ExitMenuItem.Text = "&Exit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// WindowMenuItem
			// 
			this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeMenuItem,
            this.WindowTileMenuItem});
			this.WindowMenuItem.Name = "WindowMenuItem";
			this.WindowMenuItem.Size = new System.Drawing.Size(63, 22);
			this.WindowMenuItem.Text = "&Window";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripSeparator2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(285, 31);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spWin,
            this.spData});
			this.statusStrip1.Location = new System.Drawing.Point(0, 169);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
			this.statusStrip1.Size = new System.Drawing.Size(285, 22);
			this.statusStrip1.TabIndex = 4;
			// 
			// spWin
			// 
			this.spWin.Name = "spWin";
			this.spWin.Size = new System.Drawing.Size(39, 17);
			this.spWin.Text = "Status";
			// 
			// spData
			// 
			this.spData.Name = "spData";
			this.spData.Size = new System.Drawing.Size(31, 17);
			this.spData.Text = "Data";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::MdiApplication.Properties.Resources.сердце;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton1.Tag = "NewDoc";
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Create new document";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::MdiApplication.Properties.Resources.квадрат;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton2.Tag = "Cascade";
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Windows cascade";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = global::MdiApplication.Properties.Resources.звезда;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton3.Tag = "Title";
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.ToolTipText = "Windows title";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// WindowCascadeMenuItem
			// 
			this.WindowCascadeMenuItem.Image = global::MdiApplication.Properties.Resources.Без_имени;
			this.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
			this.WindowCascadeMenuItem.Size = new System.Drawing.Size(118, 22);
			this.WindowCascadeMenuItem.Text = "&Cascade";
			this.WindowCascadeMenuItem.Click += new System.EventHandler(this.WindowCascadeMenuItem_Click);
			// 
			// WindowTileMenuItem
			// 
			this.WindowTileMenuItem.Image = global::MdiApplication.Properties.Resources.t;
			this.WindowTileMenuItem.Name = "WindowTileMenuItem";
			this.WindowTileMenuItem.Size = new System.Drawing.Size(118, 22);
			this.WindowTileMenuItem.Text = "&Title";
			this.WindowTileMenuItem.Click += new System.EventHandler(this.WindowTileMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
			// 
			// ParentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 191);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ParentForm";
			this.Text = "ParentForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowCascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTileMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel spWin;
        private System.Windows.Forms.ToolStripStatusLabel spData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}