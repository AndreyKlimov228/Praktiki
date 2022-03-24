using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR12_Klimov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public string text = "0";
        public MainPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            int one = 0;
            int two = 1;
            int sum = 0;

            while (50 >= sum)
            {
                sum = one + two;
                text += $"   {sum}";
                one = two;
                two = sum;
            }
            label1.Text = text;
        }
    }
}