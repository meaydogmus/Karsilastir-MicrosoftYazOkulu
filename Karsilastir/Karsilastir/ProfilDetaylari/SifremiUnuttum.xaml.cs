using Karsilastir.Views;
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
    public partial class SifremiUnuttum : ContentPage
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void Guncelle_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Güncelleme Gönderildi", "Talebiniz Alınmıştır!", "Tamam");
        }

        private void Guncel_Iptal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GirisYap());
        }
    }
}