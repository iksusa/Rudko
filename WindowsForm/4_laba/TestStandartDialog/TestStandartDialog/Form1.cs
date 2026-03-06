using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestStandartDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сохронитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
			saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
			{
				richTextBox1.SaveFile(saveFileDialog1.FileName,
				RichTextBoxStreamType.PlainText);
			}
		}

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void цветФонаШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.BackColor = colorDialog1.Color; }
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void цветФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.BackColor = colorDialog1.Color;
			}

		}

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Font = fontDialog1.Font;
			}

		}

		private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

			Stream myStream = null;
			openFileDialog1.InitialDirectory = @"c:\";
			openFileDialog1.Filter = "Текстовые файлы(*.txt)| *.txt | All files(*.*) | *.* ";
			openFileDialog1.FilterIndex = 1;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
						using (myStream)
						{
							richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk: " + ex.Message);
				}
			}
		}
		private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
			{
				saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
				if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
				{
					richTextBox1.SaveFile(saveFileDialog1.FileName,
					RichTextBoxStreamType.PlainText);
				}
			}
		}
    }
}
