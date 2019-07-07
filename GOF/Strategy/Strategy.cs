using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Strategy
{
    
    // 使用时必须提前知道所有的策略算法


    public class StrategyDemo
    {
        public static void Demo()
        {
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteError());
            context.ContextInterface();
        }
    }

    /// <summary>
    /// 上下文类
    /// </summary>
    public class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }
    }

    /// <summary>
    /// 抽象基类
    /// </summary>
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }


    //各种策略算法
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }

    public class ConcreteError : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("这个算法是错的");
        }
    }
}
