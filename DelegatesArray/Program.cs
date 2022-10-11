using System;

namespace DelegatesArray
{

    public delegate void MyDelegate(string s);
    internal class Program
    {
        private static void SayHello(string str)
        {
            Console.WriteLine("Hello, " + str);
        }
        static void Main(string[] args)
        {
            //массив делегатов
            MyDelegate[] delsArray = new MyDelegate[10];

            /*
            for (int i = 0; i < delsArray.Length; i++)
            {
                delsArray[i] = new MyDelegate(SayHello);
            }
            */

            for (int i = 0; i < delsArray.Length; i++)
            {
                delsArray[i] = SayHello;
            }

            for (int i = 0; i < delsArray.Length; i++)
            {
                delsArray[i](Convert.ToString(i));// или delsArray[i].Invoke(Convert.ToString(i));
            }

            Console.ReadKey();
        }
    }
}