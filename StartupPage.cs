using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNavigationTester
{
    internal class StartupPage : ContentPage
    {
        public StartupPage()
        {
            var buttonWithNavPage = new Button { Text = "Navigate away" };
            buttonWithNavPage.Clicked += ButtonWithNavPage_Clicked;
            var label = new Label { Text = "StartupPage" };

            Content = new VerticalStackLayout { Children = { buttonWithNavPage, label }, Padding = 10 };

        }


        private async void ButtonWithNavPage_Clicked(object sender, EventArgs e)
        {
            var toPage = new NextPage();
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(toPage));
        }
    }
}
