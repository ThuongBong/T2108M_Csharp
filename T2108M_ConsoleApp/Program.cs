using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_ConsoleApp.Session;
using System.Net.Http;
using T2108M_ConsoleApp.Dtos;
using Newtonsoft.Json;

namespace T2108M_ConsoleApp
{
    class Program
    {
        static async void Main(string[] args)
        {
            CurrentWeather currentWeather = null;
            //Call api de lay object
            currentWeather = await GetCurrentWeather();
            //print weather
            Console.WriteLine("Nhiet do: " + currentWeather.main.temp);
        }

        //call API => return 1 object CurrentWeather
        static async Task<CurrentWeather> GetCurrentWeather()
        {
            CurrentWeather curent = null;
            HttpClient client = new HttpClient();
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                string s = await res.Content.ReadAsStringAsync();
                curent = JsonConvert.DeserializeObject<CurrentWeather>(s);
            }
            return curent;
        }

         static void MainOld(string[] args)
         {
             int x = 10;
             for(int i = 0; i < 10; i++)
             {
                 Console.WriteLine("x + i = " + (x + i));
             }
             Male m = new Male();
             Male ml = new Male(29);

             Car c = new Car();
             c.Brand = "Toyota";
             Console.WriteLine(c.Brand);
             List<Car> arr = new List<Car>();
             arr.Add(c);
             arr.Add(new Car());

             Car d = new Car();
             d.Owners.Add("Nguyen Xuan Thao");
             d.Owners.Add("Nguyen Nhat Anh");

             for (int i = 0; i < d.Owners.Count; i++)
             {
                 Console.WriteLine(d.Owners[i]);
                 Console.WriteLine(d[i]);
             }
             d.Owners[0] = "Khổng Thị Thương";
             d[0] = "Khổng Thị Thương";
         }

    }
}
