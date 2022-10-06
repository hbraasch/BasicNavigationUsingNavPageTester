using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNavigationTester
{
    internal class NextPage : ContentPage
    {
        public NextPage()
        {
            var buttonBackWard = new Button { Text = "Navigate back", Margin = 10 };
            buttonBackWard.Clicked += ButtonBackWard_Clicked;
            var label = new Label { Text = "NextPage" };

            Content = new VerticalStackLayout { Children = { buttonBackWard, label }, Padding = 10 };

        }

        private async void ButtonBackWard_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
