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
    public partial class AreaTriangulo : ContentPage
    {
        public AreaTriangulo()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            var vBase = Convert.ToDouble(etrBase.Text);
            var vAltura = Convert.ToDouble(etrAltura.Text);

            lblResult.Text = $"A área do triângulo é: { vBase * vAltura / 2}";
        }
    }
}