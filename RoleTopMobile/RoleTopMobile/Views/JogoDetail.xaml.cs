<<<<<<< HEAD
﻿using RoleTopMobile.Models;
using RoleTopMobile.ViewModels;
=======
﻿using RoleTopMobile.ViewModels;
>>>>>>> db9868da8da6c1d8ef0ac30b947bd759b234245e
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
<<<<<<< HEAD
=======

>>>>>>> db9868da8da6c1d8ef0ac30b947bd759b234245e
        public JogoDetail()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = vm;
        }
    }
}