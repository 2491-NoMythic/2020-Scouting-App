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
    public partial class PitScoutingEnd : ContentPage
    {
        ZXingBarcodeImageView pitBarcode;

        public PitScoutingEnd()
        {
            InitializeComponent();
        }

        private void PitGenerateQR(object sender, EventArgs e)
        {
            pitBarcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                AutomationId = "zxingBarcodeImageView",
            };
            pitBarcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            pitBarcode.BarcodeOptions.Width = 600;
            pitBarcode.BarcodeOptions.Height = 600;
            pitBarcode.BarcodeValue = "example";

            pitLayout.Children.Insert(0, pitBarcode);
        }

        async void PitReturnHome(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}