using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalPatterns.FactoryMethod
{
    public class MargheritaPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Margherita Pizza with tomato, mozzarella, and basil.");
            Thread.Sleep(5000);
        }
    }
}
