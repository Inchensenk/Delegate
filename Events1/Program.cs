using System;

namespace Events1
{
    public delegate void EventDelegate();
    public class MyClass
    {
        public event EventDelegate myEvent = null;

        //add и remove это ключевые слова доступа для событий они делают работу с событиями более безопаснее
        public event EventDelegate MyEvent
        {
            //подписка
            add { myEvent += value; }
            //отписка
            remove { myEvent -= value; }
        }
        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
    public class Program
    {
        //Методы обработки события

        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }


        static void Main(string[] args)
        {

            MyClass instance = new MyClass();

            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += Handler2;

            instance.InvokeEvent();

            Console.WriteLine("---");
            instance.myEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}