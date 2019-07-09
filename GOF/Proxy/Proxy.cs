using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Proxy
{
    public class ProxyDemo
    {
        public static void Demo()
        {
            RealSubject subject = new RealSubject();
            Proxy proxy = new Proxy(subject);
            proxy.Request();
        }
    }

    interface Subject
    {
        void Request();
    }

    public class RealSubject : Subject
    {
        public void Request()
        {
            Console.WriteLine("真正实体的请求");
        }
    }

    public class Proxy : Subject
    {
        RealSubject subject;
        public Proxy(RealSubject subject)
        {
            this.subject = subject;
        }
        public void Request()
        {
            if(subject != null)
            {
                preRequest();
                subject.Request();
                postRequest();
            }
        }
        public void preRequest()
        {
            Console.WriteLine("处理真正请求前操作");
        }
        public void postRequest()
        {
            Console.WriteLine("处理真正请求后操作");
        }
    }
}
