using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoleTopMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaView : ContentPage
    {
        public BuscaView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnBuscar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EstadioEvents();
        }
    }
}