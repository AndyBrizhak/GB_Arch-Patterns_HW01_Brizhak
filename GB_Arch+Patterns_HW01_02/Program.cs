using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ДЗ по курсу Архитектуры и шаблоны проектирования на C# Брижак Андрей
//2. Реализовать программу из раздела «Повторяющиеся фрагменты кода» с помощью делегата Func.

namespace GB_Arch_Patterns_HW01_02
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description,
            int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы метода DummyFunc");
            DummyFunc();
            Console.WriteLine("Окончание работы метода DummyFunc");
            Console.WriteLine("Начало работы метода DummyFuncAgain");
            DummyFuncAgain();
            Console.WriteLine("Окончание работы метода DummyFuncAgain");
            Console.WriteLine("Начало работы метода DummyFuncMore");
            DummyFuncMore();
            Console.WriteLine("Окончание работы метода DummyFuncMore");
            Console.ReadLine();
        }
    }
}
