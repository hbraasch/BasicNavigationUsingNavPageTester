using BasicNavigationTester;

namespace BasicNavigationUsingNavPageTester;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartupPage());
	}
}
