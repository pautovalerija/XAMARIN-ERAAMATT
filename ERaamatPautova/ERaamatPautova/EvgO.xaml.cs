using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERaamatPautova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvgO : ContentPage
    {
        Label lblEvg;
        ScrollView scrollView;
        StackLayout stackLayout;
        public EvgO()
        {
            
            InitializeComponent();

            lblEvg = new Label();
            lblEvg.Text = Classglav.EvgO;
            scrollView = new ScrollView();
            stackLayout = new StackLayout()
            {
                Children = {lblEvg}
            };
            scrollView.Content = stackLayout;
            this.Content = scrollView;
            


        }
    }
}