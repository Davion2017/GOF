using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Prototype
{
    public class PrototypeDemo
    {
        public static void Demo()
        {
            ConcretePrototype concrete = new ConcretePrototype("201726705020");
            ConcretePrototype concrete1 = (ConcretePrototype)concrete.Clone();
            Console.WriteLine(concrete.id);
            Console.WriteLine(concrete1.id);
            concrete.id = "123456789";
            Console.WriteLine(concrete.id);
            Console.WriteLine(concrete1.id);
        }
    }

    public abstract class Prototype
    {
        public string id { get; set; }
        public Prototype(string id)
        {
            this.id = id;
        }
        public abstract Prototype Clone();
    }

    public class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id) : base(id)
        { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
