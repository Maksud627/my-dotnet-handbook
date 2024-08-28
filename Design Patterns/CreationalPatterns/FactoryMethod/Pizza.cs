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
        }

        public void Cut()
        {
            Console.WriteLine("Pizza is being cut.");
        }

        public void Box()
        {
            Console.WriteLine("Pizza is being boxed.");
        }
    }
}
