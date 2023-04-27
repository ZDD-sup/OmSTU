/*Необходимо разработать программу, которая велючает класс автомобиль, гараж, и мойка.
 Гараж будет являться коллекцией машин. Мойка может только мыть машину.
 Необходимо делегировать матью всех машиню*/
namespace _27_04_1
{
    class Car
    {
        public string Model;
        public string CarNumber;

        public Car(string model, string carNumber)
        {
            this.Model = model;
            this.CarNumber = carNumber;
        }
    }
    
    class Garage : Car 
    {
        public string GaNumbers;
        public Garage(string gaNumbers, string model, string carNumber) :base(model, carNumber)
        {
            this.GaNumbers = gaNumbers;
        }
    }
    class Washing
    {
        static public void Answer(string Model, string CarNumber, string GaNumber) => Console.WriteLine($"Машина модели: {Model}, Гос Номер: {CarNumber} с парковочного места {GaNumber} - ПОМЫТА!");
    }
    
    internal class Program
    {
        public static List<Garage> cars = new List<Garage>();
        public delegate void WasDelegat(string M, string CN, string GN);
        static void Main()
        {
            WasDelegat was = Washing.Answer; // создаём делегат функции
            string Model, CarNumber, GaNumber;
            Console.WriteLine("Заполнение Гаража. Нажмите 1 для записи машины, 2 для выхода из записи");
            Print();
            foreach(var car in cars)
            {
                was(car.Model, car.CarNumber, car.GaNumbers);
            }
            void Print()
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("Номер парковочноного места: ");
                        GaNumber = Console.ReadLine();
                        Console.Write("Модель автомобиля: ");
                        Model = Console.ReadLine();
                        Console.Write("Гос номер автомобиля: ");
                        CarNumber = Console.ReadLine();
                        cars.Add(new Garage(GaNumber, Model, CarNumber));
                        Console.WriteLine("Нажмите 1 для записи машины, 2 для выхода из записи");
                        Print();
                        break;
                    case ConsoleKey.D2:
                        break;
                    default:
                        Print();
                        break;
                }
            }
        }
    }
}