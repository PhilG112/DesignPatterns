using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// A concrete creator class
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductA();
    }
}
