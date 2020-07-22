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
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        async void BtnCadastro_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso!", "Cadastro efetuado com sucesso", "Fazer login");
            Navigation.RemovePage(this);
            App.Current.MainPage = new NavigationPage(new LoginView());
        }

        void BtnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
            App.Current.MainPage = new NavigationPage(new LoginView());
        }
    }
}