using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_WFA___Async_and_Await_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void getTarget_Click(object sender, EventArgs e)
        {
            string content = await GetTheHTMLAsyc();
            displayWindow.Text += content;
        }

        async Task<string> GetTheHTMLAsyc()
        {
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(target.Text);
            DrawStuff();
            var htmlCode = await getStringTask;
            return htmlCode;
        }

        void DrawStuff()
        {
            displayWindow.Text += "Working...\n";
            var graphics = this.CreateGraphics();
            var rect = new Rectangle(10, 300, 200, 200);
            graphics.DrawEllipse(Pens.Blue, rect);
            graphics.DrawRectangle(Pens.Red, rect);
        }
    }
}
