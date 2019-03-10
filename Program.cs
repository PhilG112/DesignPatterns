using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethod();
            Prototype();
        }

        private static void Prototype()
        {
            // Create two instances and clone each
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
        }

        private static void FactoryMethod()
        {
            var creators = new List<Creator>
            {
                new ConcreteCreatorA(),
                new ConcreteCreatorB()
            };

            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine($"Created {product.GetType().Name}");
            }
        }
    }
}
