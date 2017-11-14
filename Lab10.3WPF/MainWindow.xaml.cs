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

namespace Lab10._3WPF
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

        double Ala;
        double Lasi;
        double Karmi;
        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            Ala = double.Parse(Leveys.Text) * double.Parse(Korkeus.Text);
            Lasi = (double.Parse(Leveys.Text) - (2 * double.Parse(Karmipuu.Text))) * (double.Parse(Korkeus.Text) - (2 * double.Parse(Karmipuu.Text)));
            Karmi = (2 * double.Parse(Leveys.Text)) + (2 * double.Parse(Korkeus.Text));
            pintaala.Text = Ala.ToString();
            lasipintaala.Text = Lasi.ToString();
            karminpiiri.Text = Karmi.ToString();

            //Ikkunan piirto

            Ulompi.Height = (double.Parse(Korkeus.Text) / 3000) *260;
            Ulompi.Width = (double.Parse(Leveys.Text) / 3000) * 260;

            Sisempi.Height = ((double.Parse(Korkeus.Text) - (2 * (double.Parse(Karmipuu.Text) ))) / 3000) * 260;
            Sisempi.Width = ((double.Parse(Leveys.Text) - (2 * (double.Parse(Karmipuu.Text) ))) / 3000) * 260;
        }

        private void Leveys_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Korkeus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Karmipuu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
