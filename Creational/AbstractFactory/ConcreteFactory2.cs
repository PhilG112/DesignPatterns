using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ProductA2();

        public IAbstractProductB CreateProductB() => new ProductB2();
    }
}
