using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsM1.Models;
using XamarinFormsM1.Views;

namespace XamarinFormsM1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JogosFut : ContentPage
    {
        public JogosFut()
        {
            InitializeComponent();
            listJogos.ItemsSource = Jogo.Jogos;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculadoraBasica());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LatitudeLongitude());
        }
    }
}