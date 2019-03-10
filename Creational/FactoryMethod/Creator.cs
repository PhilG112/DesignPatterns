using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// The abstract creator class
    /// </summary>
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
