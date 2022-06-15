using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2108M_UMP.Service;
using T2108M_UMP.Module.ForeCast;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UMP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Weather : Page
    {
        public Weather()
        {
            this.InitializeComponent();
            PrintTemp();
        }
        public async void PrintTemp()
        {
            /*WeatherService ws = new WeatherService();
            CurentWeather cw = await ws.GetCurentWeather();
            Temp.Text = cw.main.temp.toString();*/
            WeatherService ws = new WeatherService();
            ForeCastWeather fw = await ws.ForeCastWeather();
          /*  for(int i = 0; i < fw.list.Count; i++)
            {
                Console.WriteLine(fw.list[i].main.temp);
            }*/
            foreach(List tt in fw.list)
            {
               // Console.WriteLine(tt.main.temp);
               Temp.Text = tt.main.temp.ToString();
                feels_like.Text = tt.main.feels_like.ToString();
                temp_min.Text = tt.main.temp_min.ToString();
                temp_max.Text = tt.main.temp_max.ToString();
                pressure.Text = tt.main.pressure.ToString();
                sea_level.Text = tt.main.sea_level.ToString();
                grnd_level.Text = tt.main.grnd_level.ToString();
                humidity.Text = tt.main.humidity.ToString();
                temp_kf.Text = tt.main.temp_kf.ToString();
            }

        }
    }
}
