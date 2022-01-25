using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnviarEmail : ContentPage
    {
        public EnviarEmail()
        {
            InitializeComponent();
        }

        private async void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            var destinatario = etrDestinatario.Text;
            var assunto = etrAssunto.Text;
            var corpo = etrCorpo.Text;

            var url = $"mailto:{destinatario}?subject:{assunto}&body{corpo}";

            await Launcher.OpenAsync(new Uri(url));
        }
    }
}