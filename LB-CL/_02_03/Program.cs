/*Издательство 3 категории людей
1. Управленцы (фио, должность, труд. книжка, издание приказов и распоряжения(дата и номер))
2. Основные (фио, должность, труд. книжка, кол-во экземляров отпечатаных в день)
3. Вспомогательные (фио, должность, труд. книжка, дата и выполненая работа (тeх. персонал))
выборка:
1. общий стаж
2. стаж работы на последнем месте
3. кол-во экземпляров отпечатаных за диапазон дат
4. работы вспомогательных
5. выборка приказов которое составил определённое лицо*/
using System.Security.Cryptography;

namespace _02_03
{
    internal class Program
    {
        public static List<Person> list = new List<Person>();
        
        static void Main()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1://добавить нового сотрудника
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1://управленец
                            Manager(1);
                            break;
                        case ConsoleKey.D2://Основыные
                            Averages(2);
                            break;
                        case ConsoleKey.D3://вспомогательные
                            Low(3);
                            break;
                    }
                    break;
                case ConsoleKey.D2://выборка

                    break;
                default:
                    Main();
                    break;
            }
            Main();
            Console.ReadKey();
        }



        static public void Manager(int A)//управленец
        {
            Console.Write("Указать нового управленца? (Enter - Да, Space - нет)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Data(A);
                Console.Write("\nУказать нового управленца? (Enter - Да, Space - нет)\n->");
            }
        }
        static public void Averages(int A)//средний
        {
            Console.Write("Указать нового среднего рабочего? (Enter - Да, Space - нет)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Data(A);
                Console.Write("\nУказать среднего рабочего? (Enter - Да, Space - нет)\n->");
            }
        }
        static public void Low(int A)//нисший
        {
            Console.Write("Указать нового среднего рабочего? (Enter - Да, Space - нет)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Data(A);
                Console.Write("\nУказать среднего рабочего? (Enter - Да, Space - нет)\n->");
            }

        }



        static public void Data(int A)
        {
            List<Book> books = new List<Book>();
            Console.Write("Укажите ФИО: ");
            var name = Console.ReadLine();
            Console.Write("Укажите должность: ");
            var job = Console.ReadLine();
            Console.Write("Трудовая книжка\n Указать стаж?(Enter - да, Space - нет)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Write("Укажите дату трудоуствройства: ");
                string Start = Console.ReadLine();
                Console.Write("Укажите дату увольнения: ");
                string End = Console.ReadLine();
                Console.Write("Укажите место работы: ");
                string Work = Console.ReadLine();
                books.Add(new Book(Start, End, Work));

                Console.Write("Указать стаж ? (Enter - да, Space - нет)\n->");
            }
            if (A == 1)
            {
                List<Manage> manages = new List<Manage>();
                Console.Write("\nУказать приказ?(Enter - да, Space - нет)\n->");
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Ведите дату приказа: ");
                    string data = Console.ReadLine();
                    Console.WriteLine("Укажите номер приказа: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    manages.Add(new Manage(data, number));
                    Console.Write("\nУказать приказ?(Enter - да, Space - нет)\n->");
                }
                list.Add(new Person(name, job, books, manages));
            }
            else if (A == 2)
            {
                Console.Write("Укажите количество опечатаных экземпляров в день: ");
                int qu = Convert.ToInt32(Console.ReadLine());
                list.Add(new Person(name, job, books, qu));
            }
            else if (A == 3)
            {
                List<Low> lows = new List<Low>();
                Console.Write("Хотите указать выполненую работу?(Enter - да)\n->");
                while(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Write("Укажите дату(##.##.####): ");
                    string data = Console.ReadLine();
                    Console.Write("Опишите выволненую работу: ");
                    string low = Console.ReadLine();
                    lows.Add(new Low(data, low));
                }
                list.Add(new Person(name, job, books, lows));
            }
        }

    }


    public class Person 
    {
        private string Name;
        private string Job;
        private List<Book> BooK;
        private List<Manage> Decress;
        private int Quantity;
        private List <Low> Lows;
        public Person(string Name, string Job, List<Book> BooK, List<Manage> Decress)
        {
            this.Name = Name;
            this.Job = Job;
            this.BooK = BooK;
            this.Decress = Decress;
        }
        public Person(string Name, string Job, List<Book> BooK, int quantity)
        {
            this.Name = Name;
            this.Job = Job;
            this.BooK = BooK;
            this.Quantity = quantity;
        }
        public Person(string Name, string Job, List<Book> BooK, List<Low> Lows)
        {
            this.Name = Name;
            this.Job = Job;
            this.BooK = BooK;
            this.Lows = Lows;
        }
    }
    public class Book//макет трудовой книжки
    {
        private string Startwork;
        private string Endwork;
        private string Work;
        public Book (string Startwork, string Endwork, string Work)
        {
            this.Startwork = Startwork;
            this.Endwork = Endwork;
            this.Work = Work;
        }
    }
    public class Manage//макет указов
    {
        private string date;
        private int number;
        public Manage(string date, int number)
        {
            this.date = date;
            this.number = number;
        }
    }
    public class Average
    {
        private int Quantity;
        public Average(int quantity)
        {
            this.Quantity = quantity;
        }
    }
    public class Low
    {
        private string date;
        private string works;
        public Low(string date, string works)
        {
            this.date = date;
            this.works = works;
        }
    }

}