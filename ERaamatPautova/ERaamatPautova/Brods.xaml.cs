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
    public partial class Brods : ContentPage
    {
        Label lblBrods;
        ScrollView scrollView;
        StackLayout stackLayout;
        public Brods()
        {
            InitializeComponent();
            lblBrods = new Label();
            lblBrods.Text = Classglav.Brods;
            scrollView = new ScrollView();
            stackLayout = new StackLayout()
            {
                Children = { lblBrods }
            };
            scrollView.Content = stackLayout;
            this.Content = scrollView;

        }
    }
}