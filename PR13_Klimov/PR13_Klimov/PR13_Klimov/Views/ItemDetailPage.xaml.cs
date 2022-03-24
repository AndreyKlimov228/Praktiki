using PR13_Klimov.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PR13_Klimov.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}