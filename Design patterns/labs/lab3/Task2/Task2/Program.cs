using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime.season = Season.spring;
            Shop shop = new Shop();
            shop.ShowJuices();
            Console.ReadKey();
        }
    }
}
