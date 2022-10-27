using System;

namespace Events2
{
    
    public delegate void KeyPressEventDelegate();

    /// <summary>
    /// Класс издатель
    /// </summary>
    public class KeyboardMaster
    {
        public event KeyPressEventDelegate wKeyPressedEvent = null!;
        public event KeyPressEventDelegate sKeyPressedEvent = null!;

        public void WKeyPressedEvent()
        {
            //если на событие что то подписанно то мы его вызываем
            if(wKeyPressedEvent != null)
                wKeyPressedEvent.Invoke();
        }

        public void SKeyPressedEvent()
        {
            if (sKeyPressedEvent != null)
                sKeyPressedEvent.Invoke();
        }
    }

    /// <summary>
    /// Класс обработчик
    /// </summary>
    public class Program
    {
        
        //обработчики нажатия на кнопки
        static private void buttonW_Click()
        {
            Console.Clear();
            Console.WriteLine("\nВперед");
        }

        static private void buttonS_Click()
        {
            Console.Clear();
            Console.WriteLine("\nНазад");
        }


        static void Main(string[] args)
        {
            KeyboardMaster master = new KeyboardMaster();
            master.wKeyPressedEvent += buttonW_Click;
            master.sKeyPressedEvent += buttonS_Click;

            //enum который содержит в себе все кнопки клавиатуры
            ConsoleKey pressedKey;

            //Имитация открытого окна интерфейсного приложения
            while (true)
            {
                //получаем нажатую кнопку, если она была нажата
                pressedKey = Console.ReadKey().Key;

                switch (pressedKey)
                {
                    //если нажата клавиша W, то срабатывают все методы подписанные на событие wKeyPressedEvent
                    case ConsoleKey.W:
                        master.WKeyPressedEvent();
                        break;

                    //если нажата клавиша S, то срабатывают все методы подписанные на событие sKeyPressedEvent
                    case ConsoleKey.S:
                        master.SKeyPressedEvent();
                        break;
                }
            }
        }
    }
}

/*
 По сути интерфейсные приложения это в бесконечном цикле работающее окно, 
оно непрерывно ждет каких-то действий со стороны пользователя, 
непрерывно слушает действия пользователя чтобы их как-то обработать

 */