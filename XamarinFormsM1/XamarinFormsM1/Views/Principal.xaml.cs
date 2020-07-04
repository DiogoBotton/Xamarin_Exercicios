using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsM1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
            btExecutar.Clicked += BtExecutar_Clicked;
            btNext1.Clicked += BtNext1_Clicked;
        }

        private void BtNext1_Clicked(object sender, EventArgs e)
        {
            // Navegação entre páginas, segundo parametro para fazer animação
            Navigation.PushAsync(new CalculadoraBasica(), true);
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num.Text))
                result.Text = Convert.ToInt32(num.Text) % 2 == 0 ? "O número é PAR!" : "O número é ÍMPAR!";
            else
                result.Text = "Digite um número.";
        }
    }
}