using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsApp.AppIdioma
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppIdiomaMain : ContentPage
    {
        public AppIdiomaMain()
        {
            InitializeComponent();
        }

        private async void BtnCores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppIdiomaCores());
        }

        private async void BtnNumeros_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppIdiomaNumeros());
        }

        private async void BtnFamiliares_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppIdiomaFamiliares());
        }

        private async void BtnSair_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Alerta", "Deseja realmente sair?", "Sim", "Não");

            if (result)
            {
                Process.GetCurrentProcess().CloseMainWindow();
                Process.GetCurrentProcess().Close();
            }
        }
    }
}