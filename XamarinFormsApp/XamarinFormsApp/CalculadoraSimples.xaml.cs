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
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        public void Execute(object objectSender, EventArgs e)
        {
            var operation = ((Button)objectSender).Text;
            var valorA = Convert.ToDouble(etrValorA.Text);
            var valorB = Convert.ToDouble(etrValorB.Text);

            switch (operation)
            {
                case "+":
                    lblResult.Text = (valorA + valorB).ToString();
                    break;
                case "-":
                    lblResult.Text = (valorA - valorB).ToString();
                    break;
                case "/":
                    if (valorB == 0)
                        lblResult.Text = "0";
                    else
                        lblResult.Text = (valorA / valorB).ToString();
                    break;
                case "*":
                    lblResult.Text = (valorA * valorB).ToString();
                    break;
            }
        }
    }
}