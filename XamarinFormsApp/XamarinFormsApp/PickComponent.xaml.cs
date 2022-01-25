using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickComponent : ContentPage
    {
        public PickComponent()
        {
            InitializeComponent();
        }

        public bool NumeroPar(int numero) => numero % 2 == 0;

        public int NumeroFatorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;

            return numero * NumeroFatorial(numero - 1);
        }

        public bool NumeroPrimo(int numero)
        {
            var jaDividiu = false;

            for (int i = 2; i <= numero-1; i++)
            {
                if (numero % i == 0 && !jaDividiu)
                {
                    jaDividiu = true;
                }
                else if (numero % i == 0 && jaDividiu)
                {
                    return false;
                }
            }

            return true;
        }

        private void BtnVerificar_Clicked(object sender, EventArgs e)
        {
            var operacao = pckOperacao.SelectedItem as string;
            var valor = Convert.ToInt32(etrValor.Text);
            string resposta = string.Empty;

            switch (operacao)
            {
                case "Número Primo":
                    resposta = NumeroPrimo(valor) ? "É um número primo" : "Não é um número primo";
                    break;
                case "Numero Par":
                    resposta = NumeroPar(valor) ? "É um número par" : "Não é um número par";
                    break;
                case "Calcular o Fatorial":
                    resposta = $"O Fatorial de {valor} é {NumeroFatorial(valor)}";
                    break;
                default:
                    break;
            }

            lblResult.Text = resposta;
        }
    }
}