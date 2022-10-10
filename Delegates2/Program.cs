using System;
using System.Security.Cryptography;

namespace Delegates2
{
    //создание делегата
    public delegate void MyDelegate();


    internal class Program
    {
        private static void Method1()
        {
            Console.WriteLine("Method1!");
        }

        private static void Method2()
        {
            Console.WriteLine("Method2!");
        }
        private static void Method3()
        {
            Console.WriteLine("Method3!");
        }

        static void Main(string[] args)
        {
            //создаем экземпляр делегата и указываем что он не содержит ссылок на объект (null)
            MyDelegate mD = null;

            //создаем еще один экземпляр делегата и сообщаем его с методом Method1
            //и ниже аналогично 
            MyDelegate mD1 = new MyDelegate(Method1);
            MyDelegate mD2 = new MyDelegate(Method2);
            MyDelegate mD3 = new MyDelegate(Method3);


            //Комбинирование делегатов
            mD = mD1 + mD2 + mD3;

            /*//запуск комбинированного делегата. Делегат mD сообщен с методами: Method1, Method2, Method3                                                                  
            mD();*/

            Console.WriteLine("Введите число от 1 до 7");

            int result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    mD1();
                    break;

                case 2:
                    mD2.Invoke();
                    break;

                case 3:
                    mD3();
                    break;

                case 4:
                    mD();
                    break;

                case 5:
                    //присваиваиваем новому делегату результат разгруппировки делегатов
                    MyDelegate mD4 = mD - mD1;
                    mD4();
                    break;

                case 6:
                    MyDelegate mD5 = mD - mD2;
                    mD5();
                    break;

                case 7:
                    MyDelegate mD6 = mD - mD3;
                    mD6();
                    break;

                    default:
                    Console.WriteLine("Число должно быть от 1 до 7!");
                        break;

            }

            Console.ReadKey();

        }

    }
}

/*
 1) Комбинированные делегаты - делегаты, содержащие в себе более одного метода

 2) + опреатор группировки делегатов
    - опреатор разгруппировки делегатов

 3) Делегаты являются immutable то есть делегаты это неизменяемые типы данных
 */