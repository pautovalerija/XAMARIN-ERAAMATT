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
    public partial class MM : ContentPage
    {
        Label lblMM;
        ScrollView scrollView;
        StackLayout stackLayout;
        public MM()
        {
            InitializeComponent();
            lblMM = new Label();
            lblMM.Text = Classglav.MM;
            scrollView = new ScrollView();
            stackLayout = new StackLayout()
            {
                Children = { lblMM }
            };
            scrollView.Content = stackLayout;
            this.Content = scrollView;

        }
    }
}