using Karsilastir.ProfilDetaylari;
using Karsilastir.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Karsilastir.Kategoriler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EtSarkuteri : ContentPage
    {
        public EtSarkuteri()
        {
            InitializeComponent();
        }
        
        List<Secim> Secimler = new List<Secim>();

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.BackgroundColor == Color.Transparent)
            {
                btn.BackgroundColor = Color.Black;
                Secimler.Add(new Secim {
                    Fiyat = int.Parse(btn.CommandParameter.ToString()), ImageName = btn.Image.File
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

        private void Listele_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            
            if (e.SelectedItem == null)
                return;
            else
            {
                Secimlerim nextPage = new Secimlerim();
                nextPage.BindingContext = Secimler;
                Navigation.PushAsync(nextPage);
                
            }

        }
    }
}