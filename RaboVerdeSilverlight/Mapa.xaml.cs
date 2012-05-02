using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace RaboVerdeSilverlight
{
	public partial class Mapa : UserControl
	{
		public Mapa()
		{
			// Required to initialize variables
			InitializeComponent();
		}

	

     

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            MainPage inicio = new MainPage();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(inicio);
        }

        private void BtnContacto_Click(object sender, RoutedEventArgs e)
        {
            Contactos COntacto = new Contactos();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(COntacto);
        }

    

        
	}
}