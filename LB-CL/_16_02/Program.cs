/*
Неоюходимо создать базу данных состоящую из объектов следующих структур:
 - объект описывает учителя в школе и содержит слуд. поля:
 - - фио
 - - дата рождения
 - - наименование организации где получил образование
 - - предмет
 - - ТРУДОВАЯ КНИЖКА
 - - - год поступление в орг
 - - - наименования организации
 - - - дата увольнение
Поиск учителей из базы даных
 - по предмету
 - по стажу работы
 - общий стаж работы
 - вывод всех сотрудников
{(1),(2),(3)}
 */
namespace _16_02
{
    class Person
    {
        public string Name;//ФИО
        public string Date;//дата рождения
        public string Education;//где обучался
        public string Item;//предмет
        public List<Book> Book;//трудовая
        public Person(string name, string date, string edu, string item, List<Book> Book)
        {
            this.Name = name;
            this.Date = date;
            this.Education = edu;
            this.Item = item;
            this.Book = Book;
        }
    }
    class Book
    {
        public string date_inst;
        public string date_del;
        public string organizac;
        public Book(string inst, string del, string org)
        {
            this.date_inst = inst;
            this.date_del = del;
            this.organizac = org;
        }
    }
    internal class Program
    {
        public static List<Person> list = new List<Person>();
        static void Main()
        {
            Console.Clear();
            Console.Write("1. Указать нового преподователя\n2. Выборка\n3. Выйти из программы\n->");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1://указать нового препода
                    Console.Write("\n1. Новый преподователь\n2. Назад в меню\n->");
                    while(Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Input();
                        Console.Write("Указать ещё одного преподователя (Enter - да, Space - нет)\n->");
                    }
                    Main();
                    break;
                case ConsoleKey.D2 ://выборка
                    Console.Write("\nВыбор преподователя:\n1. По предмету\n2. По последнему стажу работы\n3. По общему стажу работы\n4. Вывод всех преподователей\n5. Назад в меню\n->");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1://по предмету
                            Console.Write("\n1. Указать предмет\n2. В меню\n->");
                            while (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.Write("Предмет: ");
                                Print_Item(Convert.ToString(Console.ReadLine()));
                                Console.Write("\n1. Указать предмет\n2. В меню\n->");
                            }
                            Main();
                            break;
                        case ConsoleKey.D2://по стажу работы
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
                        case ConsoleKey.D3://по общему стажу
                            Console.Write("\n1. Указать общий стаж\n2. В меню\n->");
                            while (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.Write("Стаж(##.##.####): ");
                                Print_date_work_all(Convert.ToString(Console.ReadLine()));
                                Console.Write("\n1. Указать общий стаж\n2. В меню\n->");
                            }
                            Main();
                            break;
                        case ConsoleKey.D4://вывод всех сотрудников
                            Print_all();
                            Console.Write("\nДля выходда в меню нажмите Enter");
                            Console.ReadKey();
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
        static public void Print_Item(string ITEM)
        {
            foreach (Person person in list) 
            {
                if (person.Item == ITEM) Console.WriteLine(
                    "ФИО: " + person.Name + " Предмет: " + person.Item);
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
                        "ФИО: " + person.Name+
                        "Стаж: " + Date.ToString("d"));
            }
        }
        static public void Print_date_work_all(string DATE)
        {
            foreach(Person person in list)
            {
                DateTime date_all = new DateTime(0000,00,00);
                foreach(Book book in person.Book)
                {
                    var Date_ins = DateTime.Parse(book.date_inst);
                    var Date_del = DateTime.Parse(book.date_del);
                    var Date = Date_del.Subtract(Date_ins);
                    date_all = date_all + Date;
                }
                if (Convert.ToString(date_all)==DATE)
                    Console.WriteLine(
                        "ФИО: " + person.Name +
                        "Общий стаж: " + date_all.ToString("d"));
            }
        }
        static public void Print_all()
        {
            Console.Clear();
            foreach (Person person in list)
            {
                Console.WriteLine(
                    "ФИО: " + person.Name +
                    "\nДата рождения: " + person.Date +
                    "\nОрганизация обучения: " + person.Education +
                    "\nПредмет: " + person.Item);
                foreach(Book book in person.Book)
                {
                    Console.WriteLine(
                        "Работал в " + book.organizac + "\nC " + book.date_inst + " по " + book.date_del);
                }
                Console.WriteLine("<------------------------------------>");
            }
        }
        static public void Input()//заполнение данныз препода
        {
            List<Book> books = new List<Book>();
            Console.Write("Укажите ФИО: ");
            string Name = Convert.ToString(Console.ReadLine());
            Console.Write("Укажите дату рождения(##.##.####): ");
            string Date = Convert.ToString(Console.ReadLine());
            Console.Write("Укажите организацию где обучался: ");
            string Edu = Convert.ToString(Console.ReadLine());
            Console.Write("Укажите предмет преподования: ");
            string Item = Convert.ToString(Console.ReadLine());
            Console.Write("Есть стаж?(Указывать начиная с последнего места работы) (Enter - да, Space - нет)\n->");
            while(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Write("Укажите дату трудоустройства(##.##.####): ");
                string date_ins = Convert.ToString(Console.ReadLine());
                Console.Write("Укажите дату увольнения(##.##.####): ");
                string date_del = Convert.ToString(Console.ReadLine());
                Console.Write("Укажите организацию: ");
                string org = Convert.ToString(Console.ReadLine());
                books.Add(new Book(date_ins, date_del, org));
                Console.Write("Указать стаж(Enter - да, Space - нет)\n->");
            }
            list.Add(new Person(Name, Date, Edu, Item, books));
        }
    }
}