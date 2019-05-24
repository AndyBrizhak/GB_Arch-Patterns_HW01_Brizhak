using System;

//ДЗ по курсу Архитектуры и шаблоны проектирования на C# Брижак Андрей
//Задача 1 Провести рефакторинг кода из раздела «Повторяющаяся логика», применяя внедрение
//зависимостей к классу EntityBase.

namespace GB_Arch_Patterns_HW01_Brizhak
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new DefaultIdGenerator());
            
            Customer customer = new Customer(new DefaultIdGenerator());
            
            var stId = store.Id;
            customer.Description = "Pupkin";
            var customerId = customer.Id;

            Console.WriteLine(stId);
            Console.WriteLine(customer.Description);
            Console.WriteLine(customerId);
            Console.ReadKey();

        }
    }
}
