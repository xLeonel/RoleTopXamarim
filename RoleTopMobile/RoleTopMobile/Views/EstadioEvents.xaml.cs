﻿using RoleTopMobile.ViewModels;
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
    public partial class EstadioEvents : ContentPage
    {
        EstadioViewModel vm = new EstadioViewModel();
        public EstadioEvents()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = vm;
        }

        void OnClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventsDetail());
        }

        void OnClickBack(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }

        void OnClickExplore(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new BuscaView());
        }

        void OnClickMaps(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new EstadioEvents());
        }

        void OnClickArrow(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MenuView());
        }
    }
}