using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExp
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            
            Truck obj = new Truck();
            obj.Model = "Tata";
            obj.ModelPrice = 25000;
            obj.Color = "Black";
            obj.Towingcapacity = 1000;
            obj.Cargocapacity = 1500;
            obj.TruckDetails();
            obj.start();
           
            Console.ReadKey();

        }
    }
}
