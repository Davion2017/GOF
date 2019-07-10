using System;
using System.Collections.Generic;
using System.Text;
using GOF.SimpleFactory;

namespace GOF.Factory
{
    class FactoryTest
    {
        public class FactoryDemo
        {
            public static void Demo()
            {
                ManFactory manFactory = new ManFactory();
                WomanFactory womanFactory = new WomanFactory();
                RobotFactory robotFactory = new RobotFactory();

                List<Person> people = new List<Person>
                {
                    manFactory.CreatePerson(),
                    womanFactory.CreatePerson(),
                    robotFactory.CreatePerson(),
                    robotFactory.CreatePerson(),
                    manFactory.CreatePerson(),
                };
                foreach (Person item in people)
                {
                    item.doSomethins();
                }
            }
        }

        interface Nawa
        {
            Person CreatePerson();
        }

        public class ManFactory : Nawa
        {
            public Person CreatePerson()
            {
                return new Man();
            }
        }

        public class WomanFactory : Nawa
        {
            public Person CreatePerson()
            {
                return new Woman();
            }
        }

        public class RobotFactory : Nawa
        {
            public Person CreatePerson()
            {
                return new Robot();
            }
        }
    }
}
