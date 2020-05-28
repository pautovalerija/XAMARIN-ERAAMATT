using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERaamatPautova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlavStr : ContentPage
    {
        Button btnb, btnz;
        StackLayout stackLayout2;
        Image imga2;
        public GlavStr()
        {
            btnb = new Button()
            {
                Text = "Библиотека",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 40, 20, 20),
                Opacity = 0.8
            };
            btnz = new Button()
            {
                Text = "Заметки",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 20, 20, 20),
                Opacity = 0.8
            };

            stackLayout2 = new StackLayout()
            {
                Children = { btnb, btnz }
            };
            stackLayout2.Spacing = 8;
            this.Content = stackLayout2;

            imga2 = new Image { Source = "page.jpg" };
            BackgroundImageSource = ("page.jpg");

            btnb.Clicked += Btnb_ClickedAsync;
            btnz.Clicked += Btnz_ClickedAsync;
        }

        private async void Btnz_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zametki());
        }

        private async void Btnb_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Biblioteka());
        }
    }
}