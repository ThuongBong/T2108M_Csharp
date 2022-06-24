using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_ConsoleApp
{
    public delegate void ShowInfo(string s);

    public delegate int Calculation(int a, int b);
    internal class Class_test
    {

        public int TinhTong(int a, int b)
        {
            return a + b;
        }

        public int TinhHieu(int a, int b)
        {
            return a - b;
        }

        public static void PrintAll(string str)
        {
            Console.WriteLine("Hello" + str);
        }

        public void SayAboutMe(string msg)
        {
            Console.WriteLine("Say: " + msg);
        }
        public static void Main(string[] args)
        {
            ShowInfo si = new ShowInfo(PrintAll);
            si("T2108M");
            ShowInfo si2 = new ShowInfo(new Class_test().SayAboutMe);
            si2("Hello world!");
            ShowInfo si3 = new ShowInfo(PrintAll);
            si3 += new Class_test().SayAboutMe;
            si3("Hello T2108M");

            Calculation c = new Class_test().TinhTong;
            c += new Class_test().TinhTong;
            c += new Class_test().TinhHieu;
            c(4, 6);

            ShowInfo d = delegate (string s)
            {
                Console.WriteLine(s);
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            };
            d("Xin chao");  

        }
    }
}
