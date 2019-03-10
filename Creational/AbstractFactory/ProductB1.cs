using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class ProductB1 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }
}