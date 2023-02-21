namespace _16_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        class Persn
        {
            //private string Name;//ФИО
            //private string Date;//дата рождения
            //private string Education;//где образование
            //private string Item;//предмет
            public List<string> people = new List<string>();
            private List<string> history = new List<string>();
            public void Input()
            {
                Console.Write("Введите ФИО учителя: ");
                people.Add(Convert.ToString(Console.ReadLine()));
                Console.Write("Укажите дату рождения учителя: ");
                people.Add(Convert.ToString(Console.ReadLine()));
                Console.Write("Укажите место обучнеия: ");
                people.Add(Convert.ToString(Console.ReadLine()));
                Console.Write("Укажите предмет преподавания учителем: ");
                people.Add(Convert.ToString(Console.ReadLine()));
                Console.WriteLine("Заполните трудовую книжку.(Enter - записать новый стаж, Space - закончить запись)");
                while(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Employment_history();
                }
                people.AddRange(history);
            }
            private void Employment_history()
            {
                Console.Write("Начало работы: ");
                history.Add(Convert.ToString(Console.ReadLine()));
                Console.Write("Увольнение: ");
                history.Add(Convert.ToString(Console.ReadLine()));
                Console.Write("Наименование организации: ");
                history.Add(Convert.ToString(Console.ReadLine()));
            }
        }
    }
}
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