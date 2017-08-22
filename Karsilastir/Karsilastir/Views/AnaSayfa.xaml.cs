using Karsilastir.ProfilDetaylari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Karsilastir.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Secim_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Secimlerim());
        }

        private void GirisYap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GirisYap());
        }

        private void KayitOl_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KayitOl());
        }

        private void SifreUnuttum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SifremiUnuttum());
        }
    }
}