using System;

namespace Events3 
{

    public delegate void MidpointDelegate();

    //КЛАСС ИЗДАТЕЛЬ
    /// <summary>
    /// Класс рассчитывает середину отрезка
    /// </summary>
    class Counter
    {
        public event MidpointDelegate onMidpoint = null!;
        public void Count(int start, int end)
        {
            for (int i = start; i < end+1; i++)
            {
                Console.Write(i + " ");

                //когда счетчик дойдет до середины отрезка, сработает событие onMidpoint(),
                //которое вызовет все методы которые на него подписаны, в данном случае метод Hello()
                if (i == start + (end - start)/2)
                {
                    onMidpoint();
                }
                Console.Write("");
            }
        }
    }

    //КЛАСС ПОДПИСЧИК: в нем содержатся методы обработки
    internal class Program
    {
        public static void Hello()
        {
            Console.WriteLine("Доброе время суток");
        }
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            //подписка метода Hello на событие onMidpoint
            counter.onMidpoint += Hello;

            counter.Count(1, 10);

       
        }
    }
}

/*
 Событию не нужно знать сколько методов на него подписано 
Классу издателю не нужно знать сколько классов подписчиков
Не зависимо от того сколько методов подписаны на событие, когда произойдет вызов события, произойдет выполнение всех методов которые на него подписаны
 */