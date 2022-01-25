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
    public partial class SearchBar : ContentPage
    {
        private List<string> Sites = new List<string>(){"gmail.com.br","kabum.com.br", "g1.com.br"};

        public SearchBar()
        {
            InitializeComponent();
            ListaSites.ItemsSource = Sites;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = searchBar.Text;

            ListaSites.ItemsSource = Sites.Where(x => x.ToLower().Contains(texto.ToLower()));
        }
    }
}