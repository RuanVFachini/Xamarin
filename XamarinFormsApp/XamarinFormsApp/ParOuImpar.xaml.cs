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
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
        }

        private void btnExecutar_Clicked(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(etrInput.Text);
            lblResult.Text = $"O número {etrInput.Text} é { (n%2 == 0 ? "Par" : "Impar") }";
        }
    }
}