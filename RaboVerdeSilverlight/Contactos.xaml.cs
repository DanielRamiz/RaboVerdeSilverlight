using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace RaboVerdeSilverlight
{
    public partial class Contactos : Page
    {
        public Contactos()
        {
            InitializeComponent();
        }


        private void BtnMapa_Click(object sender, RoutedEventArgs e)
        {
            Mapa Mapa = new Mapa();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(Mapa);
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            MainPage inicio = new MainPage();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(inicio);
        }

        

        

    }
}
