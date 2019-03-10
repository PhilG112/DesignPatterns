using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// A Concrete creator class
    /// </summary>
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductB();
    }
}
