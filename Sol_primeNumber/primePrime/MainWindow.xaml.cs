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

namespace primePrime
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

        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtBox.Text, out int theValue))
            {
                for (int i = 2; i <= theValue / 2; i++)
                {
                    if (theValue % i == 0)
                    {
                        txtBlkOutput.Text = "It's not a prime number.";
                        break;
                    }
                    else
                    {
                        txtBlkOutput.Text = "It's a prime number.";
                    }
                }
            }
        }
    }
}
