using Microsoft.Maui.Controls;
using System;

namespace NetflixApp
{
	public partial class SegundaPage : ContentPage
	{
		public SegundaPage()
		{
			InitializeComponent();
		}

		private void OnAcercaClicked(object sender, EventArgs e)
		{
			// Navegar a la tercera página
			Navigation.PushAsync(new TercerPage());
		}

		private void OnSalirLoginClicked(object sender, EventArgs e)
		{
			// Navegar a la página de inicio de sesión (MainPage)
			Navigation.PushAsync(new MainPage());
		}
	}
}