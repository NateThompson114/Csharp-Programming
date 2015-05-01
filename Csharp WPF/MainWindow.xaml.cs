using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Csharp_WPF
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ops.SelectedIndex)
            {
                case 0:
                    Divide();
                    break;
                case 1:
                    Multiply();
                    break;
            }
        }

        private void Multiply()
        {
            var x = double.Parse(value1.Text);
            var y = double.Parse(value2.Text);

            if (y != 0)
            {
                results.Content = (x/y).ToString();
            }
            else
            {
                results.Content = "Division by zero not allowed";
            }
        }

        private void Divide()
        {
            var x = double.Parse(value1.Text);
            var y = double.Parse(value2.Text);

            results.Content = (x*y).ToString();
        }
    }
}
