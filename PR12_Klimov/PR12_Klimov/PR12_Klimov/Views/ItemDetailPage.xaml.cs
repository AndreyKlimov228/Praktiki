using PR12_Klimov.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PR12_Klimov.Views
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