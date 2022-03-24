using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR14_Klimov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Timer timer;
        int hours = 0, mins = 0, secs = 0, milliseconds = 0;
        private void buttonStart_Cliced(object sender, EventArgs e)
        {
            if (buttonTimer.Text == "Запуск")
            {
                timer = new Timer();
                timer.Interval = 1;
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
                buttonTimer.Text = "Остановка";
            }
            else if (buttonTimer.Text == "Остановка")
            {
                buttonTimer.Text = "Запуск";
                timer.Stop();
                timer = null;
            }

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            milliseconds++;
            if (milliseconds >= 1000)
            {

                secs++;
                milliseconds = 0;
            }
            if (secs == 59)
            {

                mins++;
                secs = 0;

            }
            if (mins == 59)
            {
                hours++;
                mins = 0;
            }
            Device.BeginInvokeOnMainThread(() =>
            {
                label1.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, secs);
            });
        }
    }
}