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
    public partial class EventsDetail : ContentPage
    {
        public EventsDetail()
        {
            InitializeComponent();
        }

        void OnClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JogoDetail());
        }

        void OnClickBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}