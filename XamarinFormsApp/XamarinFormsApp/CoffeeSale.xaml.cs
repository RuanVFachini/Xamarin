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
    public partial class CoffeeSale : ContentPage
    {
        public int Quantidade { get; set; } = 0;
        public double ValorTotal { get; set; } = 0;
        public double ValorUnitario { get; set; } = 5;

        public CoffeeSale()
        {
            InitializeComponent();
        }

        private void ButtonIncreaseDecrease_Clicked(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;

            if (text == "-")
            {
                if (Quantidade > 0)
                    Quantidade--;
            } else
            {
                Quantidade++;
            }

            ValorTotal = Quantidade * ValorUnitario;

            lblQtd.Text = $"Quantidade: {Quantidade}";
            lblResult.Text = $"Total (R$): {ValorTotal}";
        }
    }
}