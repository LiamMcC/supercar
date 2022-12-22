using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperCarApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage

        

    {


        private readonly string SecureStorageKey = "MySecureStorageKey";
        private readonly string SecureStorageKey1 = "MySecureStorageKey1";
        private readonly string SecureStorageKey2 = "MySecureStorageKey2";

        public Profile()



        {


            InitializeComponent();
        }




        protected override async void OnAppearing()
        {
            base.OnAppearing();

            person.Text = await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey)
                ?? "No value";

            yourTown.Text = "Our Recrds Show You Live In : " + await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey2) 
                ?? "No value";

            yourCar.Text = "You have picked " + await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey1) + " as your favourite car!"
                ?? "No value";
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
            await Navigation.PushAsync(new EditProfile());
        }

        private async void GoMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mappage());
        }


        async void Button_Upload(System.Object sender, System.EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick a photo"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();

                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }

        async void Button1_Take(System.Object sender, System.EventArgs e)
        {
            var result = await MediaPicker.CapturePhotoAsync();

            if (result != null)
            {
                var stream = await result.OpenReadAsync();

                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }




    }
}