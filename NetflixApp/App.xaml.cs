using Microsoft.Maui.Controls;

namespace NetflixApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}
	}
}