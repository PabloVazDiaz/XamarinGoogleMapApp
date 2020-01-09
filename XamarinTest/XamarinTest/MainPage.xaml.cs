using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTravelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("XamarinGoogleMapApp.Assets.Images.plane.png", assembly);
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(emailEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                Navigation.PushAsync( new HomePage());
            }
        }
    }
}
