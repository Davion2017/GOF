using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Facade
{
    /* 如果把医院作为一个子系统，按照部门职能，这个系统可以划分为挂号、门诊、划价、化验、收费、取药等。
     * 看病的病人要与这些部门打交道，就如同一个子系统的客户端与一个子系统的各个类打交道一样，不是一件容易的事情。
     * 医院可以设置一个接待员的位置，由接待员负责代为挂号、划价、缴费、取药等。
     * 这个接待员就是外观模式中Facade角色的体现，病人只接触接待员，由接待员与各个部门打交道。 
     */

    public class FacadeTestDemo
    {
        public static void Demo()
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Todo();
        }
    }
    public class Receptionist
    {
        public void Todo()
        {
            Register register = new Register();
            Outpatient outpatient = new Outpatient();
            Pricing pricing = new Pricing();
            Medicine medicine = new Medicine();
            register.Method();
            outpatient.Method();
            pricing.Method();
            medicine.Method();
        }
    }

    public class Register
    {
        public void Method()
        {
            Console.WriteLine("挂号");
        }
    }

    public class Outpatient
    {
        public void Method()
        {
            Console.WriteLine("门诊");
        }
    }

    public class Pricing
    {
        public void Method()
        {
            Console.WriteLine("划价");
        }
    }

    public class Medicine
    {
        public void Method()
        {
            Console.WriteLine("取药");
        }
    }
}
