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
    public partial class DjenEir : ContentPage
    {
        Label lblDjenEir;
        ScrollView scrollView;
        StackLayout stackLayout;
        public DjenEir()
        {
            InitializeComponent();
            lblDjenEir = new Label();
            lblDjenEir.Text = Classglav.DjenEir;
            scrollView = new ScrollView();
            stackLayout = new StackLayout()
            {
                Children = { lblDjenEir}
            };
            scrollView.Content = stackLayout;
            this.Content = scrollView;

        }
    }
}