﻿using PR13_Klimov.Services;
using PR13_Klimov.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR13_Klimov
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
