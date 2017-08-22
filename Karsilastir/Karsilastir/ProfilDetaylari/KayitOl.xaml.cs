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
    public partial class KayitOl : ContentPage
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void Kaydet_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Kayıt Gönderildi", "Kaydınız Başarı İle Alınmıştır!", "Tamam");
        }

        private void iptal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GirisYap());
        }
    }
}