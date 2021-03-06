﻿namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone() => (Prototype)MemberwiseClone();
    }
}
