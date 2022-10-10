using System;

namespace LambdaOperators1
{
    public delegate int SubDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             //Делегат объявлен по сильной ссылке
            SubDelegate subDelegate = (x, y)=> 
            { 
                int result = x-y;

                return result; 
            };
            */

            //делегат объявлен по слабой ссылке
            int c = new SubDelegate((x, y) =>
            {
                int result = x - y;

                return result;
            }).Invoke(10,8);

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}

/*
 Лямбда-оператор - это многооператорное выражение-лямбда, а выражение-лямбда - это однооператорный лямбда-оператор. 
 */