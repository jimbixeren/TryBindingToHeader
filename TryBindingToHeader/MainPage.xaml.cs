using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using tryHeaderFoder;

namespace TryBindingToHeader
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked_Add(object sender, EventArgs e)
        {

            Navigation.PushAsync(new AddPage());

        }

        private void ToolbarItem_Clicked_Match(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatchPage());

        }
    }
}
