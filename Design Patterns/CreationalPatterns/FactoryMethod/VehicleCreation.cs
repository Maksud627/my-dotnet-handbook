using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalPatterns.FactoryMethod
{
    public class VehicleCreation
    {
        // factory pattern example for different vehicle object creation
        public interface IVehicle 
        {
            // we could use abstract class here also, and abs mathods to override then from the different cars
            void Drive();
        }

        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Driving a car");
            }

        }

        public class Bicycle : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("RIding a bicycle");
            }
        }

        // main factory class
        public class VehicleFactory
        {
            public IVehicle CreateVehicle(string vehicleType)
            {
                switch(vehicleType)
                {
                    case "car": return new Car();
                    case "bicycle": return new Bicycle();
                    default: throw new ArgumentException("Not a valid vehicle type");
                }
            }
        }

    }
}
