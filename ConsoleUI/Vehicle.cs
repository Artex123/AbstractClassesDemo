using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     public abstract class Vehicle
    {
        public int Year {get; set;} = 0;
        public string Make { get; set; } = "generic";
        public string Model { get; set; } = "generic";

        

        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine("This is my virtual method in my vehicle class");
        }

    }
}
