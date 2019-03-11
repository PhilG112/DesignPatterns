using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// The abstract creator class
    /// </summary>
    public interface ICreator
    {
        IProduct FactoryMethod();
    }
}
