using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Karsilastir.Views
{
    public class MyMaster : MasterDetailPage
    {
        public static MyMaster Control;
        public MyMaster()
        {
            Control = this;
            Master = new HamburgerMenu();
            Detail = new NavigationPage(new AnaSayfa());
        }
    }
}
