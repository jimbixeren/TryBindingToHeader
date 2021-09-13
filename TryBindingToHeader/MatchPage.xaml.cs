using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tryHeaderFoder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchPage : ContentPage
    {
        public MatchPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Save(object sender, EventArgs e)
        {

            var text = save.Text;

            Navigation.PopAsync();
        }
    }
}