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
using JAMK.IT;
namespace VKO46AutoDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot;
        private const string polku = @"D:\\kuvat\\";
        public MainWindow()  //metodi
        {
            //tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            Naytakuva("autotalli.png");

            //pyydetään BL-kerrokselta autot, ja näytetään ne käyttäjälle
            autot = AutoTalli.HaeAutot();
            //asetetaan comboboxiin kaikki eri automerkit
            //käsin koodaamalla versio1
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            merkit.Add("Renault");
            cmdAutot.ItemsSource = merkit;
            //versio2: parempi kysytään LINQ:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmdAutot.ItemsSource = result;

        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;
        }

        private void Naytakuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAutot.Stretch = Stretch.Fill;
                imgAutot.Source = pic;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemma itse populoineet datagridin auto-olioilla, jotenki kukin Dg:n jäsen on itseasissa Auto-Olio
            object obj = dgAutot.SelectedItem;
            if (obj !=null)
            {
                Auto valittu = (Auto)obj;
                Naytakuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void cmdAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //suodatetaan datagridin näkyviin vain valittu merkki

            string merkki = cmdAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            Naytakuva("autotalli.png");
        }
    }
}
