using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsApp.AppIdioma;
using XamarinFormsApp.AppWiki;
using XamarinFormsApp.NavegacaoHierarquica;

namespace XamarinFormsApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new Page1());
            //MainPage = new NavigationPage(new AppIdiomaMain());
            //MainPage = new AbrirSiteExterno();
            //MainPage = new PickComponent();
            //MainPage = new EnviarEmail();
            MainPage = new XamarinFormsApp.SearchBar();

            //Tabbed Page
            //var tb = new TabbedPage();
            //tb.Children.Add(new Page1());
            //tb.Children.Add(new Page2());
            //MainPage = tb;

            //Carousel Page
            //var cs = new CarouselPage();
            //cs.Children.Add(new Page1());
            //cs.Children.Add(new Page2());
            //MainPage = cs;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
