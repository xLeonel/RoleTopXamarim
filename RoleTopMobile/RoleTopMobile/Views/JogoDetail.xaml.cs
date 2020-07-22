using RoleTopMobile.ViewModels;
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
    public partial class JogoDetail : ContentPage
    {
        JogoViewModel vm = new JogoViewModel();

        public JogoDetail()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = vm;
        }
    }
}