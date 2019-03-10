using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class ProductB2 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }
}