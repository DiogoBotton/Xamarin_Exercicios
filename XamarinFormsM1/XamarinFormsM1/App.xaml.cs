using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsM1.Models;

namespace XamarinFormsM1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Necessário classe "NavigationPage" para fazer navegação de páginas (passar de uma página para outra clicando em um botão, por exemplo).
            MainPage = new NavigationPage(new Principal());
        }

        protected override void OnStart()
        {
            // Criação dos times
            Time.times.Add(new Time()
            {
                Nome = "Santos",
                Estadio = "Vila Belmiro",
                Img = "Santos.png"
            });
            Time.times.Add(new Time()
            {
                Nome = "Corinthians",
                Estadio = "Itaquera",
                Img = "Corinthians.png"
            });
            Time.times.Add(new Time()
            {
                Nome = "Atlético Paranaense",
                Estadio = "Arena da Baixada",
                Img = "Atletico.png"
            });


            // Montagem dos jogos
            Jogo.Jogos.Add(new Jogo()
            {
                TimeCasa = Time.times[0],
                TimeVisitante = Time.times[2],
                PlacarCasa = 2,
                PlacarVisitante = 1,
                Estadio = Time.times[0].Estadio
            });
            Jogo.Jogos.Add(new Jogo()
            {
                TimeCasa = Time.times[0],
                TimeVisitante = Time.times[1],
                PlacarCasa = 3,
                PlacarVisitante = 0,
                Estadio = Time.times[1].Estadio
            });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
