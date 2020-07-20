using RoleTopMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoleTopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstadioEvents : ContentPage
    {
        EstadioViewModel vm = new EstadioViewModel();
        public EstadioEvents()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}