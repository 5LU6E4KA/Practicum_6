using System;

namespace Practicum_6
{
    class Counter
    {
        public delegate void MethodCount(ConsoleColor color);
        public delegate void MethodOtpravki(ConsoleColor color);
        public event MethodCount Couns;
        public event MethodOtpravki Start;
        public void Count()
        {
            Console.WriteLine("Начинаем отсчет запуска ракеты!");
           
            for (int i = 5; i > -1; i--)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Start(ConsoleColor.Yellow);
                }
                if (i == 0)
                {
                    Couns(ConsoleColor.Green);
                }
            }
        }
    }
    class Comands_I
    {
        public void Message(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Вперед! Полный пуск");
            Console.ResetColor();
        }
        public void Message2(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Приготовиться!!!");
            Console.ResetColor();
        }
    }
    class Comands_II
    {
        public void Message(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Так точно!");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter Counter = new Counter();
            Comands_I Comands1 = new Comands_I();
            Comands_II Comands2 = new Comands_II();

            Counter.Couns += Comands1.Message;
            Counter.Couns += Comands2.Message;
            Counter.Start += Comands1.Message2;

            Counter.Count();
        }
    }
}
