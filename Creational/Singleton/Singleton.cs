using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// The 'Singleton' class, this has been modified from DoFactories implementation to be thread safe
    /// </summary>
    public class Singleton
    {
        private static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance => _lazy.Value;
    }
}
