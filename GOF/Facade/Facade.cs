using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Facade
{
    public class FacadeDemo
    {
        public static void Demo()
        {
            Facade facade = new Facade();
            facade.MethodA();
            Console.WriteLine("-----------");
            facade.MethodB();
        }
    }

    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }
    public class Facade
    {
        SubSystemOne one = new SubSystemOne();
        SubSystemTwo two = new SubSystemTwo();

        public void MethodA()
        {
            one.MethodOne();
            two.MethodTwo();
        }

        public void MethodB()
        {
            two.MethodTwo();
            one.MethodOne();
            two.MethodTwo();
        }
    }
}
