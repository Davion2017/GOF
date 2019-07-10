using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Prototype
{

    public class PrototypeTestDemo
    {
        public static void Demo()
        {
            Resume resume = new Resume("黄小华");
            resume.setPersonInfo("男", "20");
            resume.setWorkExperience("2017-2020", "江西师范大学");

            Resume resume1 = (Resume)resume.Clone();
            resume1.setWorkExperience("2013-2017", "临川一中");
            resume.Display();
            Console.WriteLine("-------");
            resume1.Display();
        }

        public static void DemoDeep()
        {
            ResumeDeep resume = new ResumeDeep("黄小华");
            resume.setPersonInfo("男", "20");
            resume.setWorkExperience("2017-2020", "江西师范大学");

            ResumeDeep resume1 = (ResumeDeep)resume.Clone();
            resume1.setWorkExperience("2013-2017", "临川一中");

            resume.Display();
            Console.WriteLine("--------");
            resume1.Display();
        }
    }
    public class Resume : ICloneable
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string timeArea { get; set; }
        public string company { get; set; }
        public Resume(string name)
        {
            this.name = name;
        }

        public void setPersonInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void setWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}", this.name, this.sex, this.age);
            Console.WriteLine("{0}, {1}", this.timeArea, this.company);
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }

    public class WorkExperience : ICloneable
    {
        public string timeArea { get; set; }
        public string company { get; set; }
        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }

    public class ResumeDeep : ICloneable
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        WorkExperience work = new WorkExperience();
        public ResumeDeep(string name)
        {
            this.name = name;
        }
        
        private ResumeDeep(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void setPersonInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void setWorkExperience(string workdate, string company)
        {
            work.timeArea = workdate;
            work.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}", name, sex, age);
            Console.WriteLine("{0}, {1}", work.timeArea, work.company);
        }

        public object Clone()
        {
            ResumeDeep resume = new ResumeDeep(work);
            resume.name = name;
            resume.sex = sex;
            resume.age = age;
            return resume;
        }
    }
}
