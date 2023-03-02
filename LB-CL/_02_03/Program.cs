/*Издательство 3 категории людей
1. Управленцы (фио, должность, труд. книжка, издание приказов и распоряжения(дата и номер))
2. Основные (фио, должность, труд. книжка, кол-во экземляров отпечатаных в день)
3. Вспомогательные (фио, должность, труд. книжка, дата и выполненая работа (тух. персонал))
выборка:
1. общий стаж
2. стаж работы на последнем месте
3. кол-во экземпляров отпечатаных за диапазон дат
4. работы вспомогательных
5. выборка приказов которое составил определённое лицо*/
namespace _02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            //Person person= new Person();
            //person.People();
            list.Add(new Person());
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name;//{ get; set; }//разобраться с get set  и сделать это в список 
        public string Job;//{ get; set; }
        public List <string> book = new List<string>();//{ get; set; }
        public void People()
        {
            Console.Write("Укажите ФИО: ");
            Name = Console.ReadLine();
            Console.Write("Укажите должность: ");
            Job = Console.ReadLine();
            BOOK(book);   
        }
        void BOOK(List<string> book)
        {
            Console.Write("Укажите дату трудоуствройства: ");
            book.Add(Console.ReadLine());
            Console.Write("Укажите дату увольнения: ");
            book.Add(Console.ReadLine());
            Console.Write("Укажите место работы: ");
            book.Add(Console.ReadLine());
        }

    }
    class Managers
    {

    }
    class Secondary
    {

    }
    class Auxiliary
    {

    }
}