using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// A concrete creator class
    /// </summary>
    public class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod() => new ConcreteProductA();
    }
}
