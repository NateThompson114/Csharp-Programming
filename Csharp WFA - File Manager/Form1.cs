using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_WFA___File_Manager
{
    public partial class Form1 : Form
    {
        public string DefaultLocal = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public string DefaultFilter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        PrintDocument mydoc = new PrintDocument();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = DefaultLocal;
            openFileDialog1.Filter = DefaultFilter;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var sreader = new StreamReader(openFileDialog1.FileName))
                {
                    try
                    {
                        richTextBox1.Text = sreader.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Check your issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = DefaultLocal;
            saveFileDialog1.Filter = DefaultFilter;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter swriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    try
                    {
                        swriter.Write(richTextBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "File failed to save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;
            printDialog1.Document = mydoc;

            var result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                mydoc.PrintPage += doc_PrintPage;
                mydoc.Print();
            }
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var style = FontStyle.Regular;
            switch (styleSelector.Text)
            {
                case "Regular":
                    style = FontStyle.Regular;
                    break;
                case "Bold":
                    style = FontStyle.Bold;
                    break;
                case "Italic":
                    style = FontStyle.Italic;
                    break;
            }
            var writingFont = new Font(styleSelector.Text, int.Parse(sizeSelector.Text), style);

            e.Graphics.DrawString(richTextBox1.Text, writingFont, Brushes.Blue, 50, 50);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = mydoc;
            mydoc.PrintPage += doc_PrintPage;
            printPreviewDialog1.Show();
        }
    }
}
