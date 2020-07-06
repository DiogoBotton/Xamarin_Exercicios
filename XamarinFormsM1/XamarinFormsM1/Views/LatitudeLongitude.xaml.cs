using Plugin.ExternalMaps;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsM1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LatitudeLongitude : ContentPage
    {
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        public LatitudeLongitude()
        {
            InitializeComponent();
        }

        private async void btLatLong_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Instancia a propriedade CrossGeolocator e pega o local atual (Current) do dispositivo pelo GPS
                var locator = CrossGeolocator.Current;
                //Precisão desejada (provavelmente em metros)
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(timeout: TimeSpan.FromSeconds(10));

                lat.Text = Latitude.ToString();
                @long.Text = Longitude.ToString();

                Latitude = position.Latitude;
                Longitude = position.Longitude;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro:", ex.Message, "Ok");
            }
        }

        private void btExibirMap_Clicked(object sender, EventArgs e)
        {
            try
            {
                CrossExternalMaps.Current.NavigateTo("XamarinExercicios", this.Latitude, this.Longitude);
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro:", ex.Message, "Ok");
            }
        }
    }
}