C# boasts a rich ecosystem of design patterns that promote flexibility, maintainability, and reusability in software development. Here's a breakdown of some of the most fundamental design patterns you'll encounter in C#:

**Creational Patterns**
** Idea about creational design pattern: ** Creational design patterns deal with object creation mechanisms. 
They help in controlling the object instantiation process and provide flexibility in how objects are created.
 
* **Singleton:** Ensures a class has only one instance and provides a global point of access to it. Ideal for managing shared resources or configurations.
* **Factory Method:** Defines an interface for creating an object but lets subclasses decide which class to instantiate. 
* Promotes loose coupling between the creator and the concrete products.
* **Abstract Factory:** Provides an interface for creating families of related or dependent objects without specifying their concrete classes. Useful for creating platform-independent code.
* **Builder:** Separates the construction of a complex object from its representation, allowing the same construction process to create various representations. Simplifies the creation of objects with many optional parameters.
* **Prototype:** Creates new objects by copying existing objects (prototypes) instead of creating them from scratch. Improves performance when object creation is expensive.

**Structural Patterns**

* **Adapter:** Allows incompatible interfaces to work together by wrapping an existing class with a new interface. Bridges the gap between existing code and new requirements.
* **Decorator:** Dynamically adds new behavior to an object without altering its structure. Offers a flexible alternative to subclassing for extending functionality.
* **Facade:** Provides a simplified interface to a complex subsystem. Makes a complex system easier to use and understand.
* **Composite:** Treats individual objects and compositions of objects uniformly. Represents part-whole hierarchies, enabling clients to treat them consistently.
* **Proxy:** Controls access to an object, providing a surrogate or placeholder for another object to control access to it. Can be used for lazy initialization, remote access, or logging.

**Behavioral Patterns**

* **Observer:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. Decouples objects that need to be kept in sync.
* **Strategy:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Lets the algorithm vary independently from the clients that use it.
* **Command:** Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
* **Template Method:** Defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. Lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
* **Iterator:** Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. Abstracts the traversal of different data structures.

Remember that these are just a few examples, and there are many other valuable design patterns in the C# world. The key is to understand their principles and apply them judiciously to craft elegant and maintainable software solutions.

If you would like, you can request more information or examples on specific design patterns. Just let me know! 


This is one of the best dependency injection video: https://youtu.be/tTJetZj3vg0



#1: Singleton pattern:

When calling a constructor from a class, it always creates new fresh object to deal with(a constructor call must always return a new object by design.), 
to get already created instance, using singleton pattern can help to deal with it. 
Logger.cs is an example of it, in this way throughout the project we can
use single instance of the logger object.

Also provide a global access point to that instance (accessible from anywhere in the program), 
ensures unsafe overwritten of the global object. 

way to make a singleton class: 1. make the default constructor private (so that prevents other objects from using it)
2. create a static creation method that calls the default private constructor[1] under the hood. (which basically acts as a constructor)

#2: Factory method:

