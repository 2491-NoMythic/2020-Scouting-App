using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoMythic_Scouting_Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Config : ContentPage
    {
        public int deviceNum;
        public static Config config;

        public Config()
        {
            InitializeComponent();
            deviceNum = 1;
            deviceNumCounter.Text = deviceNum.ToString();
        }

        public static Config getInstance()
        {
            if(config == null)
            {
                config = new Config();
            }
            return config;
        }

        public void subtractDeviceNum(object sender, EventArgs e)
        {
            if(deviceNum > 1)
            {
                deviceNum--;
                deviceNumCounter.Text = deviceNum.ToString();
            }
        }

        public void addDeviceNum(object sender, EventArgs e)
        {
            if (deviceNum < 6)
            {
                deviceNum++;
                deviceNumCounter.Text = deviceNum.ToString();
            }
        }
    }
}