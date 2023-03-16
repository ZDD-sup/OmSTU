using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;

namespace _16_03
{
    internal class Program
    {
        static void Main()
        {
            var people = new string[]{ "Sam", "Bob", "Tom", "Kate", "Art", "Bob", "Gotto" };
            ArrayList list = new ArrayList { "Pyki", "Kaki", 123 };
            Console.WriteLine(
                "1. Array для работы в массиве\n" +
                "2. ArrayList класс");
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D1://работа с массивос

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:     //индекс элемента "Kate"
                            Console.WriteLine($"Array.BinarySearch(people, \"Kate\") -> {Array.BinarySearch(people, "Kate")}");
                            break;
                        case ConsoleKey.D2:     //индекс первого элемента "Tom"
                            Console.WriteLine($"Array.IndexOf(people, \"Tom\") -> {Array.IndexOf(people, "Tom")}");
                            break;
                        case ConsoleKey.D3:     //индекс последнего элемента "Tom"
                            Console.WriteLine($"Array.LastIndexOf(people, \"Tom\") -> {Array.LastIndexOf(people, "Tom")}");
                            break;
                        case ConsoleKey.D4:     //Длинна массива
                            Console.WriteLine($"people.Length -> {people.Length}");
                            break;
                        case ConsoleKey.D5:
                            Console.WriteLine("Изменяет порядок элементов в массиве");
                            Array.Reverse(people);      //изменяет порядок элементов в массиве
                            foreach (var pe in people)
                                Console.Write($"{pe}, ");
                            Console.WriteLine("изменение порядкка элементов в массиве с 2 элемента 3 шт");
                            Array.Reverse(people, 2, 3);//изменение порядкка элементов в массиве с 2 элемента 3 шт
                            foreach (var pe in people)
                                Console.Write($"{pe}, ");
                            break;
                        case ConsoleKey.D6:
                            Console.WriteLine("сортировка массива");
                            Array.Sort(people);         //сортировка массива
                            foreach (var pe in people)
                                Console.Write($"{pe}, ");
                            break;
                        case ConsoleKey.D7:     //Размерность массива
                            Console.WriteLine($"people.Rank -> {people.Rank}");
                            break;
                        case ConsoleKey.D8:     //Длина элемента больше 3 
                            Console.WriteLine($"Array.FindIndex -> {Array.FindIndex(people, person => person.Length > 3)}");
                            break;
                    }
                    break;
                case ConsoleKey.D2://работа с листом
                    switch(Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            list.AddRange(people);                                  //добавление массива
                            list.Add(13);                                           //добавление int
                            list.Add(2.3);                                          //добавление double
                            foreach (object pe in list)
                                Console.Write($"{pe}, ");
                            break;
                        case ConsoleKey.D2://количество элементов списка
                            Console.WriteLine($"list.Count -> {list.Count}");
                            break;
                    }
                    break;
            }
            Main();
            
            



        }
    }
}