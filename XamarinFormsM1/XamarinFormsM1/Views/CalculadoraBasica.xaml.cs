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
    public partial class CalculadoraBasica : ContentPage
    {
        public CalculadoraBasica()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Casting converter sender para tipo Button, para obter o próprio botão
            Button bt = (Button)sender;
            double result = 0;
            if (!string.IsNullOrEmpty(numB.Text) && !string.IsNullOrEmpty(numA.Text))
            {
                switch (bt.Text)
                {
                    case "+":
                        result = Convert.ToDouble(numA.Text) + Convert.ToDouble(numB.Text);
                        break;
                    case "-":
                        result = Convert.ToDouble(numA.Text) - Convert.ToDouble(numB.Text);
                        break;
                    case "/":
                        result = Convert.ToDouble(numA.Text) / Convert.ToDouble(numB.Text);
                        break;
                    case "*":
                        result = Convert.ToDouble(numA.Text) * Convert.ToDouble(numB.Text);
                        break;
                    default:
                        break;
                }
                resultAB.Text = result.ToString();
            }
            else
                resultAB.Text = "Preencha os campos A e B!";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JogosFut());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Principal());
        }
    }
}