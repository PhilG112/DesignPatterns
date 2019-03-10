using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ProductA1();

        public IAbstractProductB CreateProductB() => new ProductB1();
    }
}