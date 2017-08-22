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
    public partial class GirisYap : ContentPage
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void Karsilastir_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyMaster();
        }

        private void Unuttum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SifremiUnuttum());
        }

        private void KayitOl_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KayitOl());
        }
    }
}
