using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns;

/*
 * This is a logger service based on singleton pattern
 * This class only has one instance and that is accessible by
 * shared resources, that means this is a global point of access
 * 
 * One instance, one way of access from any resources,
 * Example of singleton pattern
 * 
 */
public class Logger
{
    private static Logger _instance;

    // private constructor prevents external instantiation
    private Logger() { }

    public static Logger Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"This is a log message: {message}");
    }

}


/*
 * In this example:

    The Logger class has a private constructor, ensuring that it can't be instantiated directly from outside the class.
    The Instance property provides the global access point to the single Logger instance.
    The first time Instance is accessed, a new Logger object is created and stored in the _instance variable. Subsequent accesses return the same instance.
    Benefits of the Singleton Pattern

    Controlled access to a single instance
    Reduced memory footprint (only one instance exists)
    Global access point for convenience
    Considerations

    Can make unit testing more challenging due to the global state.
    Overuse can lead to tight coupling and hidden dependencies.
    In multithreaded environments, additional synchronization might be needed to ensure thread safety.
 * 
 */
