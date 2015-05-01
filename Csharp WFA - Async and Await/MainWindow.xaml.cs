using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System;

namespace Csharp_WFA___Async_and_Await
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void getHTML_Click(object sender, RoutedEventArgs e)
        {
            var content = await GetTheHTMLAsync();
            displayWindow.AppendText(content);
        }

        async Task<string> GetTheHTMLAsync()
        {
            var client = new HttpClient();
            var getStringTask = client.GetStringAsync(target.Text);
            DrawStuff();
            var htmlCode = await getStringTask;
            return htmlCode;
        }

        void DrawStuff()
        {
            displayWindow.AppendText("Working...\n");
            Graphics graphics = this.CreateGraphics();
            var rect = new Rectangle(10, 300, 200, 200);
            graphics.DrawEllipse(Pens.Blue, rect);
            graphics.DrawRectangle(Pens.Red, rect);

        }
    }
}
