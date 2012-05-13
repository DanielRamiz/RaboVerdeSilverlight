using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Interop;
using System.Windows.Navigation;

namespace RaboVerdeSilverlight
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();

            Fondo.Begin();
			
			
		}

      

    

        private void BtnMapa_Click(object sender, RoutedEventArgs e)
        {
            
            Mapa Mapa = new Mapa();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(Mapa);
        }

        private void BtnContacto_Click(object sender, RoutedEventArgs e)
        {
            Contactos  COntacto = new Contactos ();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(COntacto);
        }

       

        private void BtnReservaciones_Click(object sender, RoutedEventArgs e)
        {
            Habitaciones habitacion = new Habitaciones();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(habitacion);
        }

    

  

        

		

		
	}
}