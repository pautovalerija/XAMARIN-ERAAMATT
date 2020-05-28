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
    public partial class Biblioteka : ContentPage
    {
        Button btn1k, btn2k, btn3k, btn4k;
        StackLayout stackLayout3;
        Image imga3;
        public Biblioteka()
        {
            btn1k = new Button()
            {
                Text = "Евгений Онегин",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 40, 20, 20),
                Opacity = 0.8
            };
            btn2k = new Button()
            {
                Text = "Бродский. Сборник",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 20, 20, 20),
                Opacity = 0.8
            };
            btn3k = new Button()
            {
                Text = "Мастер и Маргарита",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 20, 20, 20),
                Opacity = 0.8
            };
            btn4k = new Button()
            {
                Text = "Джен Эир",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 20, 20, 20),
                Opacity = 0.8
            };

            btn1k.Clicked += Btn1k_ClickedAsync;
            btn2k.Clicked += Btn2k_ClickedAsync;
            btn3k.Clicked += Btn3k_ClickedAsync;
            btn4k.Clicked += Btn4k_ClickedAsync;

            stackLayout3 = new StackLayout()
            {
                Children = { btn1k, btn2k, btn3k, btn4k }
            };
            stackLayout3.Spacing = 8;
            this.Content = stackLayout3;

            imga3 = new Image { Source = "page.jpg" };
            BackgroundImageSource = ("page.jpg");
        }

        private async void Btn4k_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DjenEir());
        }

        private async void Btn3k_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MM());
        }

        private async void Btn2k_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Brods());
        }

        private async void Btn1k_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EvgO());
        }
    }
}