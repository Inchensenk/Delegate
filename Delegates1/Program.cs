using System;

namespace Delegates
{
    //зоздание делегата типа int с двумя принимаемыми параметрами
    public delegate int AddDelegate(int a, int b);

    class Mathematics
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание экземпляра класса  Mathematics
            Mathematics mathematics = new Mathematics();

            //создание экземпляра делегата AddDelegate
            //и сообщение экземпляру делегата, экземпляр класса Mathematics с методом этого класса Add
            AddDelegate aD = new AddDelegate(mathematics.Add);

            //вызов метода сообщенного делегату через Invoke
            int result = aD.Invoke(10, 15);

            //вывод результата метода сообщенного делегату в консоль
            Console.WriteLine(result);

            //передача в консоль укороченную запись вызова метода  сообщенного делегату
            Console.WriteLine(aD(8, 9));

            //метод ожидающий нажатия клавиши, для того, чтобы консоль не закрылась
            Console.ReadKey();
        }
    }
}