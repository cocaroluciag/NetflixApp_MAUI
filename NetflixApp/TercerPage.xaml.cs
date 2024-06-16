using Microsoft.Maui.Controls;
using System;
using Microsoft.Maui.ApplicationModel.Communication;

namespace NetflixApp
{
	public partial class TercerPage : ContentPage
	{
		public TercerPage()
		{
			InitializeComponent();
		}

		public void VolverSegundaActivity(View view)
		{
			// Navega a la segunda página
			Navigation.PushAsync(new SegundaPage());
		}

		public void VolverLoginTerceraActivity(object sender, EventArgs e)
		{
			// Navega a la página de login
			Navigation.PushAsync(new MainPage());
		}

		private void OnEnviarCorreoClicked(object sender, EventArgs e)
		{
			var emailMessage = new EmailMessage
			{
				Subject = "Asunto del correo",
				Body = "Cuerpo del correo",
				To = new List<string> { "cocaroluciaguadalupe@gmail.com" }
			};

			Email.ComposeAsync(emailMessage);
		}

		private void OnSalirLoginClicked(object sender, EventArgs e)
		{
			// Navegar a la página de inicio de sesión (MainPage)
			Navigation.PushAsync(new MainPage());
		}

		private void OnLlamarClicked(object sender, EventArgs e)
		{
			if (PhoneDialer.Default.IsSupported)
			{
				PhoneDialer.Default.Open("+54 2954-497786");
			}
			else
			{
				DisplayAlert("Error", "El dispositivo no admite llamadas telefónicas.", "OK");
			}
		}
	}
}