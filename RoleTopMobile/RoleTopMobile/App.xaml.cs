using RoleTopMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoleTopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            MainPage = new JogoDetail();
=======
            MainPage = new ConfiguracaoView();
>>>>>>> bf8885af6bb0b8e98591e4a1272498fa55c7ff9d
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
