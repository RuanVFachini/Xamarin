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
    public partial class AbrirSiteExterno : ContentPage
    {
        public AbrirSiteExterno()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped_MercadoLivre(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.mercadolivre.com.br"));
        }

        private void TapGestureRecognizer_Tapped_Uol(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.uol.com.br"));
        }

        private void TapGestureRecognizer_Tapped_Kabum(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.kabum.com.br"));
        }
    }
}