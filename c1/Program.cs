using System;

namespace c1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            String name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;
            
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");
            

            Console.WriteLine($"Имя: {name} Возраст: {age} Вес: {weight}м");
            Console.WriteLine("Имя: {0} Возраст: {2} Вес: {1}м", name, weight, age);



            */


            Console.Write("Введите имя:");
            string name = Console.ReadLine();

            Console.Write("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер зарплаты:");
            decimal salary = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м Зарплата: {salary}$");

            Console.ReadKey();

        }
    }
}
