using PR12_Klimov.ViewModels;
using PR12_Klimov.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PR12_Klimov
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
