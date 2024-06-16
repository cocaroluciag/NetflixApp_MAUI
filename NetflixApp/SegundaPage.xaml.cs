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
			// Navegar a la tercera p�gina
			Navigation.PushAsync(new TercerPage());
		}

		private void OnSalirLoginClicked(object sender, EventArgs e)
		{
			// Navegar a la p�gina de inicio de sesi�n (MainPage)
			Navigation.PushAsync(new MainPage());
		}
	}
}