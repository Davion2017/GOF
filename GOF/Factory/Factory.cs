using System;
using System.Collections.Generic;
using System.Text;
using GOF.SimpleFactory;

namespace GOF.Factory
{

    public class FactoryDemo
    {
        public static void Demo()
        {
            IFactory factory = new AddFactory();
            Operation operation = factory.CreateOperation();
            operation.NumberA = 1;
            operation.NumberB = 2;
            Console.WriteLine(operation.GetResult());
        }
    }
    /// <summary>
    /// 定义工厂抽象接口
    /// </summary>
    interface IFactory
    {
        Operation CreateOperation();
    }

    // 每种对象的创建都有自己独立的工厂
    public class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }

    public class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }

    public class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }

    public class DivFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
