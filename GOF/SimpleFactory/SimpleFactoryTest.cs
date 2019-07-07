using System;
using System.Collections.Generic;
using System.Text;

namespace GOF
{
    /*
     * 使用简单工厂模式模拟女娲（Nvwa）造人(Person)，如果传入参数M，则返回一个Man对象，如果传入参数W，则返回一个对象Woman。
     * 现在需要增加一个新的Robot类，如果传入参数R,则返回一个Robot对象，对代码进行修改并注意女娲的变化。 
     * （1）绘制简单工厂模式结构视图； 
     * （2）请绘制该实例类图，并代码实现。
     */
    class SimpleFactoryTest
    {
        public static void Demo()
        {
            string gender = Console.ReadLine();
            Person person = Nvwa.createPerson(gender);
            if(person != null)
            {
                person.doSomethins();
            }
        }
    }

    public class Nvwa
    {
        public static Person createPerson(string gender)
        {
            Person person = null;
            switch (gender)
            {
                case "M":
                    person = new Man();
                    break;
                case "W":
                    person = new Woman();
                    break;
                case "R":
                    person = new Robot();
                    break;
                default:
                    Console.WriteLine("暂时不会造这种生物");
                    break;
            }
            return person;
        }
    }

    public class Person
    {
        public virtual void doSomethins()
        { }
    }
    
    public class Man : Person
    {
        public override void doSomethins()
        {
            Console.WriteLine("我是男人，除了不能生孩子其他啥都能干");
        }
    }
    public class Woman : Person
    {
        public override void doSomethins()
        {
            Console.WriteLine("我是女人，就爱看男人吹牛");
        }
    }


    public class Robot : Person
    {
        public override void doSomethins()
        {
            Console.WriteLine("我是机器人，执行人类给我的任务");
        }
    }
}
