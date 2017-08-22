using Karsilastir.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Karsilastir
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisSayfa : ContentPage
    {
        public GirisSayfa()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void KarsilastirButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyMaster();
        }
    }
}