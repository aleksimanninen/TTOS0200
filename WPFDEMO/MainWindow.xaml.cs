﻿using System;
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

namespace WPFDEMO
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nimi = txtnimi.Text;
            txbmessu.Text = "Terve " + nimi;
        }

        private void btnSuurenna_Click(object sender, RoutedEventArgs e)
        {
            //suurrennattaan TextBlockin kokoa
            txbmessu.FontSize = txbmessu.FontSize + 1;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem li = (ListBoxItem)cmbVarit.SelectedItem;
            string testi = li.Content.ToString();
            //string vari = cmbVarit.SelectedValue.ToString();
            txbmessu.Text = testi;
            Brush mybrush = Brushes.Blue;
            //huom! tietyt kontrollien ominaisduudet vaativat tietyn tyyppisen muuttujan!
            //tässä foregroung ominaisuus vaatii Brush-tyypin!!!
            txbmessu.Foreground = mybrush;
        }
    }
}
