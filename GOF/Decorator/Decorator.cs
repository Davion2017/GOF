using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Decorator
{

    public class DecoratorDemo
    {
        public static void Demo()
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);
            decoratorB.Operation();
        }
    }

    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }

    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "添加A状态";
            Console.WriteLine(addedState);
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        private void diff()
        {
            Console.WriteLine("B状态执行的操作");
        }
        public override void Operation()
        {
            base.Operation();
            diff();
        }
    }
}
