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
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void BtnInicio_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new EstadioEvents());
        }



        private void BtnConfig_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CadastroView());
        }


    }
}