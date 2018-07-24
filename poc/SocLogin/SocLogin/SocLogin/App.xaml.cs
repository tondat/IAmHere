using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SocLogin
{
	public partial class App : Application
	{
		public static IAuthenticate Authenticator { get; private set; }

		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		public static void Init(IAuthenticate authenticator)
		{
			Authenticator = authenticator;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
