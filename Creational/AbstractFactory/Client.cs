using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    public class Client
    {
        private IAbstractProductA _abstractProductA;

        private IAbstractProductB _abstractProductB;

        public Client(IAbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();

            Run();
        }

        private void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
