using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperCarApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfile : ContentPage
    {

        private readonly string SecureStorageKey = "MySecureStorageKey";
        private readonly string SecureStorageKey1 = "MySecureStorageKey1";
        private readonly string SecureStorageKey2 = "MySecureStorageKey2";

        public EditProfile()
        {
            InitializeComponent();
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


        async void Button_UpdateMe(System.Object sender, System.EventArgs e)
        {
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey, dfgh.Text);
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, fave.Text);
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey2, town.Text);
            await Navigation.PushAsync(new Profile());
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            dfgh.Text = await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey)
                 ?? "No Fave";

            fave.Text = await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey1)
                ?? "No Fave";

            town.Text = await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey2)
                ?? "No Town";
        }
    }
}