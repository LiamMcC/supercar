using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperCarApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarSpec : ContentPage
    {

        ObservableCollection<string> specs = new ObservableCollection<string> { "RPM point maximum power 6500RPM", "Acceleration 0 - 60 mph 4.0 secs", "Top speed 293KMH", "Acceleration 0 - 160 km/h 9.3 secs" };
        CarStuff garage = new CarStuff();
        public CarSpec()
        {
            InitializeComponent();
            garage.specs= specs;
            BindingContext = garage;
        }

        private void Canr_Clicked(object sender, EventArgs e)
        {
            garage.specs.Add(nameEntry.Text);
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

    public class CarStuff
    {

        public ObservableCollection<string> specs { get; set; }
    }
}