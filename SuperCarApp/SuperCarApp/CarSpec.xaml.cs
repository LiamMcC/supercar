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

        ObservableCollection<string> specs = new ObservableCollection<string> { "Something Here", "Something There"};
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


        private async void GoProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarSpec());
        }
    }

    public class CarStuff
    {

        public ObservableCollection<string> specs { get; set; }
    }
}