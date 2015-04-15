using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Windows_Form_App___Browser
{
    
    public partial class UDEMY_Browser : Form
    {
        public UDEMY_Browser()
        {
            InitializeComponent();
            url.Text = "https://www.google.com";
            webBrowser.Navigate(new Uri(url.Text));
            Text = @"UDEMY Browser";
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void load_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(url.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void youTubeButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.youtube.com");
        }
        
        
    }
}
