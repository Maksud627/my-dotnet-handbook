using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalPatterns.FactoryMethod
{
    internal class TestClass
    {
    }

    abstract class Vehicle
    {
        public abstract void Move();
        public void horn() 
        {
            Console.WriteLine("Vehicle is doing horn");
        }
        public void brake()
        {
            Console.WriteLine("VEhicle is braking");
        }
    }

    class Airplane : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Airplane is flying!");
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car is driving!");
        }
    }

    class FlyingCar : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("FlyingCar is flying!"); // Or choose driving behavior
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            FlyingCar myVehicle = new FlyingCar();
            myVehicle.Move();
        }
    }*/
}
