using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle: done
             * The vehicle class shall have three string properties Year, Make, and Model: done
             * Set the defaults to something generic in the Vehicle class: done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation: done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation: done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle: done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle: done
             * Provide the implementations for the abstract methods: done
             *
             * Only in the Motorcycle class will you override the virtual drive method: Done
            */

            // Create a list of Vehicle called vehicles: Done
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes: Done
            
             * Set the properties with object initializer syntax: Done
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = 2023,
                Make = "Ferrari",
                Model = "LaFerrari"   
            };
            var motorcylcle1 = new Motorcycle()
            {
                HasSideCart = false,
                Year = 2023,
                Make = "Triumph",
                Model = "Bonneville"
            };
            Vehicle vehicle1 = new Car()
            {
                HasTrunk = true,
                Make = "Dodge",
                Model = "Viper",
                Year = 2017
                
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                HasSideCart = false,
                Make = "MTT",
                Model = "420-RR",
                Year = 2023
            };
            /*
             * Add the 4 vehicles to the list: Done
             * Using a foreach loop iterate over each of the properties: Done
             */

            vehicles.Add(car1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(motorcylcle1);

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($" Year: {vehicle.Year},\n Make: {vehicle.Make},\n Model: {vehicle.Model}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
            }

            // Call each of the drive methods for one car and one motorcycle: done

            #endregion            
            Console.ReadLine();
        }
    }
}
