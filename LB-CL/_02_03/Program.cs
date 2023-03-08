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
//using System.Security.Cryptography;

namespace _02_03
{
    internal class Program
    {
        public static List<Person> list = new List<Person>();
        
        static void Main()
        {
            list.ForEach(element =>
            {
                if (element.Type == 1)
                {
                    Console.WriteLine(element.Name);
                }
                else if (element.Type == 2)
                {
                    Console.WriteLine(element.Name);

                }
                else if (element.Type == 3)
                {
                    Console.WriteLine(element.Name);

                }
            });
            Console.Write("---Меню---\n1. Добавить нового работника\n2. Выборка работников\n->");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1://добавить нового сотрудника
                    Console.Clear();
                    Console.Write("1. Управленец\n2. Основной\n3. Вспомогательный\n4. Назад в меню\n->");
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
                        default:
                            break;
                    }
                    break;
                case ConsoleKey.D2://выборка
                    switch(Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            break;
                        case ConsoleKey.D3:
                            break;
                        case ConsoleKey.D4:
                            break;
                        case ConsoleKey.D5:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.Clear();
            Main();
            Console.ReadKey();
        }



        static public void Manager(int A)//управленец
        {
            Console.Clear();
            Console.Write("Указать нового управленца? (Enter - Да, Space - нет)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Data(A);
                Console.Write("\nУказать нового управленца? (Enter - Да, Space - нет)\n->");
            }
        }
        static public void Averages(int A)//средний
        {
            Console.Clear();
            Console.Write("Указать нового среднего рабочего? (Enter - Да, Space - нет)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Data(A);
                Console.Write("\nУказать среднего рабочего? (Enter - Да, Space - нет)\n->");
            }
        }
        static public void Low(int A)//нисший
        {
            Console.Clear();
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
            string name = Console.ReadLine();
            Console.Write("Укажите должность: ");
            string job = Console.ReadLine();
            Console.Write(" - - - Трудовая книжка - - - \nУказать стаж?(Enter - да)\n->");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Write("Укажите дату трудоуствройства: ");
                string Start = Console.ReadLine();
                Console.Write("Укажите дату увольнения: ");
                string End = Console.ReadLine();
                Console.Write("Укажите место работы: ");
                string Work = Console.ReadLine();
                books.Add(new Book(Start, End, Work));
                Console.Write("Указать стаж?(Enter - да)\n->");
            }
            if (A == 1)
            {
                List<Manage> manages = new List<Manage>();
                Console.Write("\nУказать приказ?(Enter - да)\n->");
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Write("Ведите дату приказа: ");
                    string data = Console.ReadLine();
                    Console.Write("Укажите номер приказа: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    manages.Add(new Manage(data, number));
                    Console.Write("\nУказать приказ?(Enter - да)\n->");
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
                    Console.Write("Хотите указать выполненую работу?(Enter - да)\n->");
                }
                list.Add(new Person(name, job, books, lows));
            }
        }
    }


    public class Person 
    {
        public int Type;
        public string Name;
        public string Job;
        public List<Book> BooK;
        public List<Manage> Decress;
        public int Quantity;
        public List<Low> Lows;
        public Person(string Name, string Job, List<Book> BooK, List<Manage> Decress)
        {
            this.Type = 1;
            this.Name = Name;
            this.Job = Job;
            this.BooK = BooK;
            this.Decress = Decress;
        }
        public Person(string Name, string Job, List<Book> BooK, int quantity)
        {
            this.Type = 2;
            this.Name = Name;
            this.Job = Job;
            this.BooK = BooK;
            this.Quantity = quantity;
        }
        public Person(string Name, string Job, List<Book> BooK, List<Low> Lows)
        {
            this.Type = 3;
            this.Name = Name;
            this.Job = Job;
            this.BooK = BooK;
            this.Lows = Lows;
        }
        //public Person(string name, string job, List<Book> BooK)
        //{
        //    this.Name = name;
        //    this.Job = job;
        //    this.BooK = BooK;
        //}
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
    public class Manage// : Person//макет указов
    {
        private string date;
        private int number;
        public Manage(string date, int number)//, string Name, string Job, List<Book> BooK) : base(Name, Job, BooK)
        {
            this.date = date;
            this.number = number;
        }
    }
    public class Average// : Person//количество указов для среднего уровня
    {
        private int Quantity;
        public Average(int quantity)
        {
            this.Quantity = quantity;
        }
    }
    public class Low// : Person//выполненая работа дата\/описание работы
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