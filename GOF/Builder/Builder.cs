using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    public class BuilderDemo
    {
        public static void Demo()
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();
            Console.WriteLine("-----------");
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
        }
    }
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("产品建造");
            foreach (string item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
    class ConcreteBuilder1 : Builder
    {
        Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件A");
        }

        public override void BuildPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件X");
        }

        public override void BuildPartB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
