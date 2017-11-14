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
        private void TxtOstan_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ListBoxItem li = (ListBoxItem)Valuutta.SelectedItem;
                string syöte = li.Content.ToString();
                if (syöte == "EUR")
                {
                    double num1, num2;
                    num1 = double.Parse(TxtOsto.Text);
                    num2 = (num1 / 0.8997);
                    TxtMyy.Text = num2.ToString("0.00");
                }
                else
                {
                    double num1, num2;
                    num1 = double.Parse(TxtOsto.Text);
                    num2 = (num1 * 0.8997);
                    TxtMyy.Text = num2.ToString("0.00");
                }
            }
            catch (Exception)
            {
                TxtMyy.Text = "Syötä Luku";
            }
        }

        
    }
        


    
}

