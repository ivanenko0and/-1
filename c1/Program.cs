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


            Console.Write("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");






            Console.ReadKey();

        }
    }
}
