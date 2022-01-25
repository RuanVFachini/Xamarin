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
    public partial class Tabuada : ContentPage
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            var numero = Convert.ToDouble(etrNumero.Text);
            var resultList = new List<string>();
            var strTemplate = "{0} x {1} = {2}";

            for (int i = 0; i <= 10; i++)
            {
                resultList.Add(string.Format(strTemplate, numero, i, numero * i));
            }

            lvwResults.ItemsSource = resultList;
        }
    }
}