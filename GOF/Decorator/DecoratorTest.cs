using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Decorator
{
    /*
     * 用装饰模式，模拟出V仔兽和虫虫兽合体进化成机甲龙兽的过程，以及虫虫兽独立进化的路线
     * V仔兽->V仔兽EX，虫虫兽->飞虫兽，V仔兽EX+飞虫兽->机甲龙兽
     * 虫虫兽->飞虫兽->宝石虫兽
     */

    public class DigimonDemo
    {
        public static void Demo()
        {
            BirthDigimon v_mon = new BirthDigimon("V仔兽");
            BirthDigimon wormmon = new BirthDigimon("虫虫兽");
            V_mon_EX v_Mon_EX = new V_mon_EX();
            Stingmon stingmon = new Stingmon();
            Nileus nileus = new Nileus();
            Mechatrosaurus mechatrosaurus = new Mechatrosaurus();

            Console.WriteLine("虫虫兽进化路线");
            stingmon.change(wormmon);
            nileus.change(stingmon);
            nileus.evolution();
            Console.WriteLine("=====================================");
            Console.WriteLine("机甲龙兽进化路线");
            v_Mon_EX.change(v_mon);
            mechatrosaurus.change(v_Mon_EX);
            mechatrosaurus.evolution(stingmon);
        }
    }

    public abstract class Digimon
    {
        public string name;
        public abstract void evolution();
        public abstract void evolution(Digimon partner);
    }

    public class BirthDigimon : Digimon
    {
        public BirthDigimon(string name)
        {
            this.name = name;
        }
        public override void evolution()
        {
            Console.WriteLine("{0}出生了", name);
            Console.WriteLine();
        }
        public override void evolution(Digimon partner)
        { }
    }

    public class Evolution : Digimon
    {
        protected Digimon digimon;
        public void change(Digimon digimon)
        {
            this.digimon = digimon;
        }
        public override void evolution()
        {
            if(digimon != null)
            {
                digimon.evolution();
            }
        }
        public override void evolution(Digimon partner)
        { }
    }

    public class V_mon_EX : Evolution
    {
        public override void evolution()
        {
            base.evolution();
            Console.WriteLine("进化");
            this.name = "V仔兽EX";
            Console.WriteLine(this.name);
            Console.WriteLine();
        }
    }

    public class Stingmon : Evolution
    {
        public override void evolution()
        {
            base.evolution();
            Console.WriteLine("进化");
            this.name = "飞虫兽";
            Console.WriteLine(this.name);
            Console.WriteLine();
        }
    }

    public class Nileus : Evolution
    {
        public override void evolution()
        {
            base.evolution();
            Console.WriteLine("进化");
            this.name = "宝石虫兽";
            Console.WriteLine(this.name);
            Console.WriteLine();
        }
    }

    public class Mechatrosaurus : Evolution
    {
        public override void evolution(Digimon partner)
        {
            base.evolution();
            partner.evolution();
            Console.WriteLine("合体进化");
            this.name = "机甲龙兽";
            Console.WriteLine(this.name);
            Console.WriteLine();
        }
    }
}
