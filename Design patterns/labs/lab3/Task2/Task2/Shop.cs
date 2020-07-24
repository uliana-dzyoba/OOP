using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Shop
    {
        
        private AppleJuice appleJuice;
        private GrapeJuice grapeJuice;
        private OrangeJuice orangeJuice;

        JuiceFactory factory;

        private void setFactory()
        {
            if(DateTime.season==Season.autumn|| DateTime.season == Season.winter)
            {
                factory = new RichFactory();
            }
            else factory = new JaffaFactory();
        }

        public Shop()
        {
            setFactory();
            appleJuice = factory.MakeAppleJuice();
            grapeJuice = factory.MakeGrapeJuice();
            orangeJuice = factory.MakeOrangeJuice();
        }

        public void ShowJuices()
        {
            Console.WriteLine("In stock now:");
            appleJuice.Show();
            grapeJuice.Show();
            orangeJuice.Show();
        }
    }
}
