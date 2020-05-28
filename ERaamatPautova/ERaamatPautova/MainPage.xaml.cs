using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ERaamatPautova
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Button btn;
        StackLayout stackLayout;
        Label lbl, lbl2;
        Image imga;
        public MainPage()
        {
            lbl = new Label()
            {
                Text = "ЭЛЕКТРОННАЯ БИБЛИОТЕКА",
                TextColor=Color.FromHex("#f1e9e3"),
                BackgroundColor=Color.FromHex("#785e4d"),
                FontSize=20,
                FontAttributes = FontAttributes.Italic,
                Margin =new Thickness(20,30,80,45),
                Opacity=0.8
                
            };
            lbl2 = new Label()
            {
                Text = "Электронная библиотека поможет Вам намного удобнее читать Ваши любимые произведения. Запечатляйте цитаты или фразы авторов. Наслаждайтесь!",
                TextColor = Color.FromHex("#f1e9e3"),
                BackgroundColor = Color.FromHex("#785e4d"),
                FontSize = 14,
                Margin = new Thickness(80, 50, 20, 45),
                Opacity = 0.8

            };
            btn = new Button()
            {
                Text = "Читать!",
                BackgroundColor = Color.FromHex("#785e4d"),
                Margin = new Thickness(20, 130, 20, 20),
                Opacity = 0.8
                
            };
            stackLayout = new StackLayout()
            {
                Children = { lbl, lbl2, btn }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;

            btn.Clicked += Btn_ClickedAsync;
            imga = new Image { Source = "avleht.jpg" };

            BackgroundImageSource = ("avleht.jpg");
        }

        private async void Btn_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlavStr());
        }
    }
}
