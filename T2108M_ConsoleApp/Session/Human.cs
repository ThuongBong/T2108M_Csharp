using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_ConsoleApp.Session
{
    internal abstract class Human
    {
        public String name;
        int age;

        public abstract void showInfo();

        public virtual void running()
        {
            Console.WriteLine("Running..");
        }
    }
}
