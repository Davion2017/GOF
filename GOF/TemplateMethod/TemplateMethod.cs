using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.TemplateMethod
{
    public class TemplateMethodDemo
    {
        public static void Demo()
        {
            ConcreteClassA classA = new ConcreteClassA();
            ConcreteClassB classB = new ConcreteClassB();
            classA.TemplateMethod();
            Console.WriteLine("-----------------");
            classB.TemplateMethod();
        }
    }

    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("通用的模板操作");
        }
    }

    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体A类的操作1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体A类的操作2");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体B类的操作1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体B类的操作2");
        }
    }
}
