using System;
using System.Collections;
using System.Collections.Generic;

//ДЗ по курсу Архитектуры и шаблоны проектирования на C# Брижак Андрей
//2. Реализовать программу из раздела «Повторяющиеся фрагменты кода» с помощью делегата Func.

namespace GB_Arch_Patterns_HW01_02
{
    class Program
    {
        public static readonly string _Address = Constants.address;
        public static readonly string _Format = Constants.format;

        /// <summary>
        /// Функция возвращает отформатированную строку
        /// </summary>
        /// <returns></returns>
        private static string DummyFunc()
        {
           return string.Format(_Format, "Петя", "школьный друг", _Address, 30);
        }

        private static string DummyFuncAgain()
        {
            return string.Format(_Format, "Вася", "сосед", _Address, 54);
        }

        private static string DummyFuncMore()
        {
            return string.Format(_Format, "Николай", "сын", _Address, 4);
        }


        /// <summary>
        /// Функция выводит метод
        /// </summary>
        /// <param name="func">делегат</param>
        private static void MakeF(Func<string> func)
        {
            string NameMeth = func.Method.Name;
            Console.WriteLine("Start", NameMeth);
            Console.WriteLine(func());
            Console.WriteLine("Finish", NameMeth);
        }

        /// <summary>
        /// Возвращает список обобщенных делегатов
        /// </summary>
        /// <returns></returns>
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
