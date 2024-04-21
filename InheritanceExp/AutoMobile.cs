using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExp
{
    class AutoMobile
    {
       public  string Model ;
           private    int ModelId;
       public   int ModelPrice;
       public  int Year ;
        public  int Speed;
        public string Color;

        public AutoMobile()
        {
            Console.WriteLine("initializing");
        }

        public virtual  void start()
        {
            Console.WriteLine("Starting.....");
        }


    }
}
