using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    /* 背景
     * 小成希望去电脑城买一台组装的台式主机
     * 过程
     * 电脑城老板（Diretor）和小成（Client）进行需求沟通（买来打游戏？学习？看片？）
     * 了解需求后，电脑城老板将小成需要的主机划分为各个部件（Builder）的建造请求（CPU、主板blabla）
     * 指挥装机人员（ConcreteBuilder）去构建组件；
     * 将组件组装起来成小成需要的电脑（Product）
     */
    public class BuilderTestDemo
    {
        public static void Demo()
        {
            DirectorBoss boss = new DirectorBoss();
            BuildA buildA = new BuildA();
            BuildB buildB = new BuildB();

            boss.makeComputer(buildA);
            ProductComputer product = buildA.GetComputer();
            product.show();
        }
    }
    class ProductComputer
    {
        IList<string> parts = new List<string>();
        public void addPart(string part)
        {
            parts.Add(part);
        }
        public void show()
        {
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
    abstract class BuildComputer
    {
        public abstract void BuildCPU();
        public abstract void BuildGPU();
        public abstract ProductComputer GetComputer();
    }
    class BuildA : BuildComputer
    {
        ProductComputer computer = new ProductComputer();
        public override void BuildCPU()
        {
            computer.addPart("CPU：i7 8550");
        }
        public override void BuildGPU()
        {
            computer.addPart("GPU：GTX1080ti");
        }
        public override ProductComputer GetComputer()
        {
            return computer;
        }
    }
    class BuildB : BuildComputer
    {
        ProductComputer computer = new ProductComputer();
        public override void BuildCPU()
        {
            computer.addPart("CPU：i5 6550");
        }
        public override void BuildGPU()
        {
            computer.addPart("GPU：MX150");
        }
        public override ProductComputer GetComputer()
        {
            return computer;
        }
    }
    class DirectorBoss
    {
        public void makeComputer(BuildComputer builder)
        {
            builder.BuildCPU();
            builder.BuildGPU();
        }
    }
}
