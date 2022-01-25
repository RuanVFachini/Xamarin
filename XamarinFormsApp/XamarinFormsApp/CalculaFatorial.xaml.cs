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
    public partial class CalculaFatorial : ContentPage
    {
        public CalculaFatorial()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            var result = ExecutaCalculoFatorial(Convert.ToDouble(etrNumero.Text)).ToString();
            lblResult.Text = $"O Fatorial de {etrNumero.Text} é {result}";
        }

        private double ExecutaCalculoFatorial(double value)
        {
            if (value == 0 || value == 1)
                return 1;

            return value * ExecutaCalculoFatorial(value - 1);
        }
    }
}