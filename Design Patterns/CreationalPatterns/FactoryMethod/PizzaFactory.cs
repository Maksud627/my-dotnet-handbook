using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalPatterns.FactoryMethod
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            switch(type)
            {
                case "Margherita": return new MargheritaPizza();
                case "Pepperoni": return new PepperoniPizza();
                /*case "Veggie": return new VeggiePizza();
                case "Sucuklu": return new SucukluPizza();*/
                default:
                    throw new ArgumentException("Unknown pizza type.");
            }
        }
    }
}
