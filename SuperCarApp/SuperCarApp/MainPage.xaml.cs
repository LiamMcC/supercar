using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SuperCarApp
{


    public partial class MainPage : ContentPage
    {


        private readonly string SecureStorageKey1 = "MySecureStorageKey1";
        public MainPage()
        {
            InitializeComponent();
        }

        async private void OnSwiped(object sender, EventArgs e)
        {
            await DisplayAlert("Boom", "You have Added This To Your Profile Favourite Car", "OK");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Porsche");
        }

        async private void OnSwiped1(object sender, EventArgs e)
        {
            await DisplayAlert("Boom", "You have Added This To Your Profile Favourite Car", "OK");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Corvette");
        }

        async private void OnSwiped2(object sender, EventArgs e)
        {
            await DisplayAlert("Boom", "You have Added This To Your Profile Favourite Car", "OK");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Zonda A");
        }

        async private void OnSwiped3(object sender, EventArgs e)
        {
            await DisplayAlert("Boom", "You have Added This To Your Profile Favourite Car", "OK");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Zonda B");
        }

        async private void OnSwiped4(object sender, EventArgs e)
        {
            await DisplayAlert("Boom", "You have Added This To Your Profile Favourite Car", "OK");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Zonda C");
        }

        async private void OnSwiped5(object sender, EventArgs e)
        {
            await DisplayAlert("Boom", "You have Added This To Your Profile Favourite Car", "OK");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Acura");
        }


        private async void GoHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GoSpecs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarSpec());
        }

        private async void GoProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }

        private async void GoMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mappage());
        }

    }
}
