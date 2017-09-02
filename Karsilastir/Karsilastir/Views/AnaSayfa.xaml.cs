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
        List<Secim> Secimler = new List<Secim>();


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

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.BackgroundColor == Color.Transparent)
            {
                btn.BackgroundColor = Color.Black;
                Secimler.Add(new Secim
                {
                    Fiyat = int.Parse(btn.CommandParameter.ToString()),
                    ImageName = btn.Image.File
                });
            }
            else if (btn.BackgroundColor == Color.Black)
            {
                btn.BackgroundColor = Color.Transparent;
                Secimler.Remove(new Secim
                {
                    Fiyat = int.Parse(btn.CommandParameter.ToString()),
                    ImageName = btn.Image.File
                });
            }
        }

        private async void Listele_Clicked(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null)
                return;
            else
            {
                Secimlerim nextPage = new Secimlerim();
                nextPage.BindingContext = Secimler;
                await Navigation.PushAsync(nextPage);

            }

        }
    }
}