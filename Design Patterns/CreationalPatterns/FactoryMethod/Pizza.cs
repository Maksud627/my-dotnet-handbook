using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalPatterns.FactoryMethod
{
    public abstract class Pizza
    {
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Pizza is being baked.");
            Thread.Sleep(1000);
        }

        public void Cut()
        {
            Console.WriteLine("Pizza is being cut.");
            Thread.Sleep(1000);
        }

        public void Box()
        {
            Console.WriteLine("Pizza is being boxed.");
            Thread.Sleep(1000);
        }
    }
}
