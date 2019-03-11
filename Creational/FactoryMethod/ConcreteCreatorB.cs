using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// A Concrete creator class
    /// </summary>
    public class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod() => new ConcreteProductB();
    }
}
