using System;
using System.Collections.Generic;
using System.Text;

namespace GOF
{
    /// <summary>
    /// 通过简单工厂实现计算器
    /// </summary>
    public class SimpleFactoryDemo
    {
        public static void Demo()
        {
            string operate;
            Console.Write("请输入要操作的运算符：");
            operate = Console.ReadLine();
            Operation oper = OperationFactory.createOperation(operate);
            Console.Write("输入数字A：");
            oper.NumberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("输入数字B：");
            oper.NumberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("运算结果为：{0}", oper.GetResult());
        }
    }

    /// <summary>
    /// 简单工厂类，通过提供的操作运算符，返回相应的运算类型
    /// </summary>
    public class OperationFactory
    {
        public static Operation createOperation(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    Console.WriteLine("暂不支持该运算");
                    break;
            }
            return oper;
        }
    }

    /// <summary>
    /// 运算基类，提供返回运算结果的虚方法
    /// </summary>
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public virtual double GetResult()
        {
            double answer = 0;
            return answer;
        }
    }

    /// <summary>
    /// 加法类，覆写了GettResult方法
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                Console.WriteLine("被除数不能为零");
                return 0;
            }
            return NumberA / NumberB;
        }
    }
}
