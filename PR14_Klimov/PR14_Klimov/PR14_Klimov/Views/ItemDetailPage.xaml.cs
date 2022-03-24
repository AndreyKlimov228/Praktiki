using PR14_Klimov.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PR14_Klimov.Views
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