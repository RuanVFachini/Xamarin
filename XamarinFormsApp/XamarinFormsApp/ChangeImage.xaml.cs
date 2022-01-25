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
    public partial class ChangeImage : ContentPage
    {
        private bool image001 = true;
        private const string _img001 = "img001";
        private const string _img002 = "img002";

        public ChangeImage()
        {
            InitializeComponent();
        }

        private void ImageChange(object sender, EventArgs e)
        {
            if (image001)
                imgView.Source = _img002;
            else
                imgView.Source = _img001;

            image001 = !image001;
        }
    }
}