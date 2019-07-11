using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.TemplateMethod
{
    /*
     * 用模板方法模式，模拟肯德基制作不同汉堡的过程
     * 
     */
    public class TemplateMethodTestDemo
    {
        public static void Demo()
        {
            BigMac bigMac = new BigMac();
            ZingerBurger zingerBurger = new ZingerBurger();
            bigMac.makeHanburger();
            Console.WriteLine("-------------------");
            zingerBurger.makeHanburger();
        }
    }

    public abstract class Hamburger
    {
        public string name;
        public abstract void addMaterial1();
        public abstract void addMaterial2();
        public abstract void addMaterial3();
        public abstract string setName();

        public void makeHanburger()
        {
            Console.WriteLine("加面包胚");
            addMaterial1();
            Console.WriteLine("加沙拉酱");
            addMaterial2();
            Console.WriteLine("加沙拉酱");
            addMaterial3();
            Console.WriteLine("再加面包胚");
            Console.WriteLine("{0}制作完成", setName());
        }
    }

    public class ZingerBurger : Hamburger
    {
        public override string setName()
        {
            name = "香辣鸡腿堡";
            return name;
        }
        public override void addMaterial1()
        {
            Console.WriteLine("加鸡腿肉");
        }
        public override void addMaterial2()
        {
            Console.WriteLine("加生菜");
        }

        public override void addMaterial3()
        {
            Console.WriteLine("再加块芝士");
        }
    }

    public class BigMac : Hamburger
    {
        public override string setName()
        {
            name = "巨无霸汉堡";
            return name;
        }

        public override void addMaterial1()
        {
            Console.WriteLine("加生菜");
            Console.WriteLine("加牛肉");
        }
        public override void addMaterial2()
        {
            Console.WriteLine("加芝士");
            Console.WriteLine("加起司");
        }
        public override void addMaterial3()
        {
            Console.WriteLine("加牛肉");
            Console.WriteLine("加洋葱酸黄瓜");
        }
    }
}
