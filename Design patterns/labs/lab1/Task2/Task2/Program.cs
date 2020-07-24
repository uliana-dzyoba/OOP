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
            Composite KPI = new Composite("KPI");
            Composite FAM = new Composite("FAM");
            Composite IPT = new Composite("IPT");
            KPI.Add(FAM);
            KPI.Add(IPT);
            Worker lecturer = new Worker("Ann Smith", 3);
            Worker proffesor = new Worker("Noah Johnson", 7);
            Worker assistant = new Worker("James Williams", 4);
            FAM.Add(lecturer);
            FAM.Add(assistant);
            IPT.Add(proffesor);
            KPI.Display(2);
            Console.WriteLine("");
            int budget = 20;
            int balance = KPI.Pay(budget);
            Console.WriteLine("Budget to pay workers: " + budget);
            if (balance>=0)
            Console.WriteLine("Remains after payment: " + KPI.Pay(budget));
            else Console.WriteLine("Not enough resources. Lacks " + Math.Abs(balance));
            Console.ReadKey();
        }
    }
}
