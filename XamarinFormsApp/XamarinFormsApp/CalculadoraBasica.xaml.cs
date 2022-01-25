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
    public partial class CalculadoraBasica : ContentPage
    {
        private Operator operacao;
        private string acumulado, valor;

        public CalculadoraBasica()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup(object sender, EventArgs e)
        {
            Setup();
        }

        private void Setup()
        {
            operacao = Operator.NONE;
            lblResult.Text = "0";
            acumulado = string.Empty;
            valor = string.Empty;
        }

        private void MathOperationButton_Clicked(object sender, EventArgs e)
        {
            var valorBtn = ((Button)sender).Text;

            if (valorBtn == "=")
            {
                Calculate();
            } else
            {
                if (operacao != Operator.NONE)
                {
                    Calculate();
                }

                operacao = GetOperation(valorBtn);
            }

            DisplayUpdate();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            var valorBtn = ((Button)sender).Text;

            if (operacao == Operator.NONE)
                acumulado += valorBtn;
            else
                valor += valorBtn;

            DisplayUpdate();

        }

        private void DisplayUpdate()
        {
            string text;

            if (acumulado != string.Empty && valor != string.Empty)
                text = $"{acumulado.FormatDecimal()} {GetOperationText()} {valor.FormatDecimal()}";
            else if (acumulado != string.Empty && operacao != Operator.NONE)
                text = $"{acumulado.FormatDecimal()} {GetOperationText()}";
            else
                text = $"{acumulado.FormatDecimal()}";

            lblResult.Text = text;
        }

        private string GetOperationText()
        {
            switch(operacao)
            {
                case Operator.SUBTRACAO: return "-";
                case Operator.SOMA: return "+";
                case Operator.DIVISAO: return "/";
                case Operator.MULTIPLICACAO: return "*";
                default: return string.Empty;
            }
        }

        private Operator GetOperation(string text)
        {
            switch (text)
            {
                case "-": return Operator.SUBTRACAO;
                case "+": return Operator.SOMA;
                case "/": return Operator.DIVISAO;
                case "*": return Operator.MULTIPLICACAO;
                default: return Operator.NONE;
            }
        }


        private void Calculate()
        {
            if (double.TryParse(acumulado, out var acumuladoValue)
                && double.TryParse(valor, out var valorValue))
            {
                switch (operacao)
                {
                    case Operator.SOMA:
                        acumulado = (acumuladoValue + valorValue).ToString();
                        break;
                    case Operator.SUBTRACAO:
                        acumulado = (acumuladoValue - valorValue).ToString();
                        break;
                    case Operator.DIVISAO:
                        acumulado = valorValue == 0 
                            ? "0" 
                            : (acumuladoValue / valorValue).ToString();
                        break;
                    case Operator.MULTIPLICACAO:
                        acumulado = (acumuladoValue * valorValue).ToString();
                        break;
                    default:
                        break;
                }

                operacao = Operator.NONE;
                valor = string.Empty;
            }
        }
    }

    public enum Operator
    {
        NONE,
        SOMA,
        SUBTRACAO,
        DIVISAO,
        MULTIPLICACAO,
    }

    public class NumberButton : Button
    {
        public NumberButton()
        {
            BackgroundColor = Color.White;
            FontSize = 36;
            CornerRadius = 0;
        }
            
    }

    public class MathOperationButton : Button
    {
        public MathOperationButton()
        {
            BackgroundColor = Color.Orange;
            TextColor = Color.White;
            FontSize = 36;
            CornerRadius = 0;
        }

    }

    public static class StringExtensions
    {
        public static string FormatDecimal(this string value)
        {
            return Convert.ToDouble(value).ToString("N0");
        }
    }
}