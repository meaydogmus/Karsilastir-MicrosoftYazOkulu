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
    public partial class HamburgerMenu : ContentPage
    {
        public HamburgerMenu()
        {
            InitializeComponent();
        }

        private void Katalog_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.Katalog());
            MyMaster.Control.IsPresented = false;

        }

        private void MeyveSebze_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.MeyveSebze());
            MyMaster.Control.IsPresented = false;

        }

        private void EtSarkuteri_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.EtSarkuteri());
            MyMaster.Control.IsPresented = false;

        }

        private void Gida_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.GidaYemek());
            MyMaster.Control.IsPresented = false;

        }

        private void Bebek_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.BebekDunyasi());
            MyMaster.Control.IsPresented = false;

        }

        private void TemizlikDunyasi_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.TemizlikDunyasi());
            MyMaster.Control.IsPresented = false;

        }

        private void KisiselBakim_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.KisiselBakim());
            MyMaster.Control.IsPresented = false;

        }

        private void PetShop_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.PetShop());
            MyMaster.Control.IsPresented = false;

        }

        private void OyuncakEglence_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.OyuncakEglence());
            MyMaster.Control.IsPresented = false;

        }

        private void Kirtasiye_Tapped(object sender, EventArgs e)
        {
            MyMaster.Control.Detail.Navigation.PushAsync(new Kategoriler.Kirtasiye());
            MyMaster.Control.IsPresented = false;

        }
    }
}