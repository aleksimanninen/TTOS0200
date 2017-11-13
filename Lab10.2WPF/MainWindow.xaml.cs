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

namespace Lab10._2WPF
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

        double num1;
        double num2;
        private void Osto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (osto.Text == null)
            {
                maksu.Text = 0.ToString();
            }
            else
            {
                num1 = double.Parse(osto.Text);
                num2 = num1 * 0.8997;
                maksu.Text = num2.ToString("0.00");
            }
        }

        private void Maksu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}

