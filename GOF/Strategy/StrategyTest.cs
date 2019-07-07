using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Strategy
{
    public class Demo
    {
        public static void TraveDemo()
        {
            PersonContext person = new PersonContext(new Car());
            person.TraveInterface();
        }

        public static void SortDemo()
        {
            SortContext sort = new SortContext(new BubbleSort());
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            sort.SortInterface(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    /*
     * 出行旅游：我们可以有几个策略可以考虑：
     * 可以骑自行车，汽车，做火车，飞机。每个策略都可以得到相同的结果，
     * 但是它们使用了不同的资源。
     * 选择策略的依据是费用，时间，使用工具还有每种方式的方便程度 。
     */
    #region 旅行示例
    public class PersonContext
    {
        TraveStrategy traveStrategy;
        public PersonContext(TraveStrategy strategy)
        {
            traveStrategy = strategy;
        }

        public void TraveInterface()
        {
            traveStrategy.TraveInterface();
        }
    }
    public abstract class TraveStrategy
    {
        public abstract void TraveInterface();
    }

    public class Bike : TraveStrategy
    {
        public override void TraveInterface()
        {
            Console.WriteLine("骑自行车");
        }
    }

    public class Car : TraveStrategy
    {
        public override void TraveInterface()
        {
            Console.WriteLine("开汽车");
        }
    }
    #endregion

    /*
     * 排序策略:某系统提供了一个用于对数组数据进行操作的类，该类封装了对数组的常见操作，
     * 如查找数组元素、对数组元素进行排序等。现以排序操作为例，使用策略模式设计该数组操作类，
     * 使得客户端可以动态地更换排序算法，可以根据需要选择冒泡排序或选择排序或插入排序，
     * 也能够灵活地增加新的排序算法。
     * */
    #region 暂时只写了一个排序策略，可以增加
    public class SortContext
    {
        SortStrategy sort;
        public SortContext(SortStrategy sort)
        {
            this.sort = sort;
        }
        public void SortInterface(int[] arr)
        {
            sort.SortInterface(arr);
        }
    }
    public abstract class SortStrategy
    {
        public abstract void SortInterface(int[] array);
    }

    public class BubbleSort : SortStrategy
    {
        public override void SortInterface(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
    #endregion
}
