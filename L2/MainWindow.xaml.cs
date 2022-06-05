using System;
using System.Collections.Generic;
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

namespace L2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button buttonn )
            {
                Random rand = new Random();
                buttonn.Background = new SolidColorBrush(Color.FromRgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));
                MessageBox.Show($"{buttonn.Name}");


            }
        }

        private void button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button buttonn)
            {

                wrppnl.Children.Remove(buttonn);
               
            }
        }
    }
}
