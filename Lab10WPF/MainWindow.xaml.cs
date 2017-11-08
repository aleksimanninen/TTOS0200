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

namespace Lab10WPF
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

        int calc1 = 0;
        int calc2 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calc1++;
            TxbCountT.Text = calc1.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            calc2++;
            TxbCountC.Text = calc2.ToString();
        }
    }
}
