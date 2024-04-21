using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExp
{
    class Truck :AutoMobile
    {
        public int Towingcapacity;
        public int Cargocapacity;

        public void TruckDetails()
        {
            Console.WriteLine("The model name is " + Model + "The model Price is " + ModelPrice + "The model Color is" + Color + "And the Fianl Truck's Towing Capacity" + Towingcapacity);
        }
        public void Tow()
        {
            Console.WriteLine("Now Towing");

        }
        public override void start()
        {
            //base.start();
            Console.WriteLine("Truck is Starting with ignition");
        }
    }
}
