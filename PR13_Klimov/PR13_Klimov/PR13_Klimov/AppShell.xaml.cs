using PR13_Klimov.ViewModels;
using PR13_Klimov.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PR13_Klimov
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
