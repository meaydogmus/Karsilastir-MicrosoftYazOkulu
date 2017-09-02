using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Karsilastir.ProfilDetaylari
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Secimlerim : ContentPage
    {
        public Secimlerim()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<Secim> data = BindingContext as List<Secim>;

            double sayi = data.Sum(x => x.Fiyat) * (new Random().NextDouble() * (2 - 1) + 1.0);
            lblToplam.Text = sayi.ToString("F");

            double sayi2 = data.Sum(x => x.Fiyat) * (new Random().NextDouble() * (2 - 1) + 1.0);
            lblToplam2.Text = sayi2.ToString("F");
        }
    }
}