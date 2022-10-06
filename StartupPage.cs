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
            var button = new Button { Text = "Navigate away" };
            button.Clicked += Button_Clicked;
            var button2 = new Button { Text = "Navigate away without NavPage" };
            button2.Clicked += ButtonWithoutNavPage_Clicked;
            var label = new Label { Text = "StartupPage" };

            Content = new VerticalStackLayout { Children = { button, button2, label }, Padding = 10 };

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var toPage = new NextPage();
            await Application.Current.MainPage.Navigation.PushModalAsync(toPage);
        }

        private async void ButtonWithoutNavPage_Clicked(object sender, EventArgs e)
        {
            var toPage = new NextPage();

            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(toPage));
        }
    }
}
