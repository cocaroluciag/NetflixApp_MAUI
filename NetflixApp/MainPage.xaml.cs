using Microsoft.Maui.Controls;
using System;

namespace NetflixApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnLoginClicked(object sender, EventArgs e)
		{
			string inputUsername = txtUsuario.Text;
			string inputPassword = txtClave.Text;

			if (inputUsername == "alumno" && inputPassword == "1234")
			{
				DisplayAlert("Inicio de sesión exitoso", "", "OK");
				Navigation.PushAsync(new SegundaPage());
			}
			else
			{
				DisplayAlert("Credenciales incorrectas", "", "OK");
			}
		}
	}
}
