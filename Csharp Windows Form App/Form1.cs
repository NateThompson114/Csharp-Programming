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

namespace Csharp_Windows_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var anotation = string.Format("{0:mmddyyyyss}", DateTime.Now);
            saveLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";
            fileName.Text = @"Sample" + anotation;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var fileLocation = Path.Combine(saveLocation.Text + fileName.Text + ".txt");
            var error = 0;
            try
            {
                if (!Directory.Exists(saveLocation.Text))
                {
                    Directory.CreateDirectory(saveLocation.Text);
                }
            }
            catch (Exception ex)
            {
                if (console.Text.Length == 0)
                {
                    console.Text = "ERROR IN CREATING FILE\n" + ex.ToString();
                }
                else
                {
                    console.Text = "ERROR IN CREATING FILE\n" + ex.ToString() + "\n" + console.Text;
                }
                error = 1;
            }


            try
            {
                using (FileStream fstream = File.Create(fileLocation))
                {
                    var text = new UTF8Encoding(true).GetBytes(rtbInput.Text);
                    fstream.Write(text, 0, text.Length);
                }
            }
            catch (Exception ex)
            {
                if (console.Text.Length == 0)
                {
                    console.Text = "ERROR IN CREATING FILE\n" + ex.ToString();
                }
                else
                {
                    console.Text = "ERROR IN CREATING FILE\n" + ex.ToString() + "\n" + console.Text;
                }
                error = 1;
            }
            if (error == 0)
            {
                if (console.Text.Length == 0)
                {
                    console.Text = "Saving file \"" +
                                   fileName.Text +
                                   ".txt\" saved to location " +
                                   fileLocation;
                }
                else
                {
                    console.Text = "Saving file \"" +
                                   fileName.Text +
                                   ".txt\" saved to location " +
                                   fileLocation + "\n" + console.Text;
                }
            }
            
            
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var error = 0;
            var fileLocation = Path.Combine(saveLocation.Text + fileName.Text + ".txt");
            rtbRead.Text = String.Empty;
            try
            {
                using (StreamReader sreader = File.OpenText(fileLocation))
                {
                    string linestoprint;
                    while ((linestoprint=sreader.ReadLine())!=null)
                    {
                        rtbRead.Text += linestoprint + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                if (console.Text.Length == 0)
                {
                    console.Text = "ERROR IN READING FILE\n" + ex.ToString();
                }
                else
                {
                    console.Text = "ERROR IN READING FILE\n" + ex.ToString() + "\n" + console.Text;
                }
                error = 1;
            }

            if (error == 0)
            {
                if (console.Text.Length == 0)
                {
                    console.Text = "Reading file \"" +
                        fileName.Text +
                        ".txt\" from location " +
                        fileLocation;
                }
                else
                {
                    console.Text = "Reading file \"" +
                        fileName.Text +
                        ".txt\" from location " +
                        fileLocation +
                        "\n" +
                        console.Text;
                } 
            }
        }
    }
}
