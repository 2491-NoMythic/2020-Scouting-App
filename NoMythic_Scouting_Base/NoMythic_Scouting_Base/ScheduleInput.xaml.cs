using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace NoMythic_Scouting_Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScheduleInput : ContentPage
    {
        string schedule;

        public ScheduleInput()
        {
            InitializeComponent();
        }

        private void OpenScanner(object sender, EventArgs and)
        {
            Scanner();
        }

        public async void Scanner()
        {

            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) => {
                // Stop scanning
                ScannerPage.IsScanning = false;
                schedule = result.Text;

                // Alert with scanned code
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert(" Scan Code ", result.Text, " OK ");
                });
            };


            await Navigation.PushAsync(ScannerPage);

        }
    }
}