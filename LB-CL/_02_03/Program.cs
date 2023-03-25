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
            Console.Write("---Меню---\n1. Добавить нового работника\n2. Выборка работников\n3. Вызод\n->");
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
                        case ConsoleKey.D1://общий стаж
                            Console.Write("\n1. Указать общий стаж\n2. В меню\n->");
                            while (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.Write("Стаж(##.##.####): ");
                                Print_date_work_all(Convert.ToString(Console.ReadLine()));
                                Console.Write("\n1. Указать общий стаж\n2. В меню\n->");
                            }
                            break;
                        case ConsoleKey.D2://стаж последней работы
                            Console.Write("\n1. Указать прошлый срок работы\n2. В меню\n->");
                            while (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.Write("Стаж(##.##.####): ");
                                Print_date_work(Convert.ToString(Console.ReadLine()));
                                Console.Write("\n1. Указать стаж\n2. В меню\n->");
                            }
                            Main();
                            break;
                        case ConsoleKey.D3://количество опечатаных экземпляров
                            Console.Write("\n1. Указать количество экземпляров за день\n2. В меню\n->");
                            while (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.Write("Введите количество экземпляров: ");
                                Print_copy(Convert.ToInt32(Console.ReadLine()));
                                Console.Write("\n1. Указать количество экземпляров за день\n2. В меню\n->");
                            }
                            Main();
                            break;
                        case ConsoleKey.D4://
                            break;
                        case ConsoleKey.D5://все приказы опр лицом
                            Console.Write("\n1. Указать ФИО\n2. В меню\n->");
                            while (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.Write("Укажите ФИО: ");
                                Print_Dexres(Convert.ToString(Console.ReadLine()));
                                Console.Write("\n1. Указать ФИО\n2. В меню\n->");
                            }
                            Main();
                            break;
                        default:
                            Main();
                            break;
                    }
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    Main();
                    break;
            }
            Console.WriteLine("\nДосвидание!");
            Console.ReadKey();
        }
        static public void Print_Dexres(string NAME)
        {
            foreach(Person person in list)
            {
                if (person.Name == NAME)
                {
                    foreach (Manage manage in person)
                    {
                        Console.WriteLine(
                            "Приказ №" + manage.number +
                            "Дата приказа: " + manage.date);
                    }
                    break;
                }
            }
        }
        static public void Print_copy(int N)
        {
            foreach(Person person in list)
            {
                if (person.Quantity == N)
                    Console.WriteLine(
                        "ФИО: " + person.Name +
                        "Количество экземпляров: " + person.Quantity);
            }
        }
        static public void Print_date_work(string DATE)
        {
            foreach (Person person in list)
            {
                //string date_ins = person.Book[0].date_inst;
                var Date_ins = DateTime.Parse(person.Book[0].date_inst);
                var Date_del = DateTime.Parse(person.Book[0].date_del);
                var Date = Date_del.Subtract(Date_ins);
                if (Convert.ToString(Date) == DATE)
                    Console.WriteLine(
                        "ФИО: " + person.Name +
                        "Стаж: " + Date.ToString("d"));
            }
        }
        static public void Print_date_work_all(string DATE)
        {
            foreach (Person person in list)
            {
                DateTime date_all = new DateTime(0000, 00, 00);
                foreach (Book book in person.Book)
                {
                    var Date_ins = DateTime.Parse(book.date_inst);
                    var Date_del = DateTime.Parse(book.date_del);
                    var Date = Date_del.Subtract(Date_ins);
                    date_all = date_all + Date;
                }
                if (Convert.ToString(date_all) == DATE)
                    Console.WriteLine(
                        "ФИО: " + person.Name +
                        "Общий стаж: " + date_all.ToString("d"));
            }
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
        public string Startwork;
        public string Endwork;
        public string Work;
        public Book (string Startwork, string Endwork, string Work)
        {
            this.Startwork = Startwork;
            this.Endwork = Endwork;
            this.Work = Work;
        }
    }
    public class Manage// : Person//макет указов
    {
        public string date;
        public int number;
        public Manage(string date, int number)//, string Name, string Job, List<Book> BooK) : base(Name, Job, BooK)
        {
            this.date = date;
            this.number = number;
        }
    }
    public class Average// : Person//количество указов для среднего уровня
    {
        public int Quantity;
        public Average(int quantity)
        {
            this.Quantity = quantity;
        }
    }
    public class Low// : Person//выполненая работа дата\/описание работы
    {
        public string date;
        public string works;
        public Low(string date, string works)
        {
            this.date = date;
            this.works = works;
        }
    }

}