using System;
using System.Collections;
using System.Collections.Generic;

//ДЗ по курсу Архитектуры и шаблоны проектирования на C# Брижак Андрей
//2. Реализовать программу из раздела «Повторяющиеся фрагменты кода» с помощью делегата Func.

namespace GB_Arch_Patterns_HW01_02
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static string DummyFunc()
        {
           return string.Format(Format, $"Петя", "школьный друг", 30);
        }

        private static string DummyFuncAgain()
        {
            return string.Format(Format, "Вася", "сосед", 54);
        }

        private static string DummyFuncMore()
        {
            return string.Format(Format, "Николай", "сын", 4);
        }


        private static void MakeF(Func<string> func)
        {
            string NameMeth = func.Method.Name;
            Console.WriteLine("Start", NameMeth);
            Console.WriteLine(func());
            Console.WriteLine("Finish", NameMeth);
        }

        private static IEnumerable<Func<string>> GetFuncSteps()
        {
            return new List<Func<string>>()
            {
                DummyFunc, DummyFuncAgain, DummyFuncMore
            };
        }

        static void Main(string[] args)
        {


            IEnumerable<Func<string>> actions = GetFuncSteps();
            foreach (var action in actions)
            {
                MakeF(action);
            }

            Console.ReadLine();
        }




    }
}
