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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        double value1 = 0;
        double value2 = 0;
        private void TxtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            value1 = double.Parse(TxtBox1.Text) * 0.8997;
            TxtBox2.Text = value1.ToString();

        }

        private void Valikko2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem li = (ListBoxItem)Valikko2.SelectedItem;
            value2 = double.Parse(TxtBox2.Text);
            TxtBox1.Text = value2.ToString();
        }
    }
}
