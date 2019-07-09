using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Proxy
{
    /*
     *  在某应用软件中需要记录业务方法的调用日志，
     *  在不修改现有业务类的基础上为每一个类提供一个日志记录代理类，
     *  在代理类中输出日志，如在业务方法Method()调用之前输出“方法Method()被调用，调
     *  用时间为2012-11-5 10:10:10”，调用之后如果没有抛异常则输出“方法Method()调用成功”，
     *  否则输出“方法Method()调用失败”。在代理类中调用真实业务类的业务方法，
     *  使用代理模式设计该日志记录模块的结构，绘制类图并使用C#语言编程模拟实现。
     */

    public class ProxyTestDemo
    {
        public static void Demo()
        {
            ProxyClass proxy = new ProxyClass(new RealClass());
            proxy.Method();
        }
    }

    interface MyClass
    {
        void Method();
    }
    /// <summary>
    /// 原始业务类
    /// </summary>
    public class RealClass : MyClass
    {
        public void Method()
        {
            Console.WriteLine("业务方法实际调用");
            string[] s = new string[1];
            Console.WriteLine(s[3]);
        }
    }

    /// <summary>
    /// 代理类
    /// </summary>
    public class ProxyClass : MyClass
    {
        RealClass real;
        public ProxyClass(RealClass real)
        {
            this.real = real;
        }
        private void outLog()
        {
            Console.WriteLine("现在是" + DateTime.Now.ToString());
        }
        private void ckeckOK(bool flag)
        {
            if(flag)
                Console.WriteLine("业务方法调用成功");
            else
                Console.WriteLine("业务方法调用失败");
        }
        public void Method()
        {
            outLog();
            bool flag;
            try
            {
                real.Method();
                flag = true;
            }
            catch
            { flag = false; }
            ckeckOK(flag);
        }
    }
}
