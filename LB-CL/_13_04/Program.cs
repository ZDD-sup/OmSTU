namespace _13_04
{
    internal class Program
    {
        static void Main()
        {
            double x, y;
            IMath IMath= new IMath();
            Print();
            void Print()
            {
                Console.Clear();
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1. Сумма"
                    + "\n2. Разница"
                    + "\n3. Умножение"
                    + "\n4. Деление");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1://сумма
                        Console.WriteLine(IMath.sum(x, y));
                        Console.ReadKey();
                        Print();
                        break;
                    case ConsoleKey.D2://разница
                        Console.WriteLine(IMath.diff(x, y));
                        Console.ReadKey();
                        Print();
                        break;
                    case ConsoleKey.D3://умножение
                        Console.WriteLine(IMath.mult(x, y));
                        Console.ReadKey();
                        Print();
                        break;
                    case ConsoleKey.D4://деление
                        if (y != 0)
                            Console.WriteLine(IMath.div(x, y));
                        else
                            Console.WriteLine("На ноль делить нельзя!");
                        Console.ReadKey();
                        Print();
                        break;
                    case ConsoleKey.D5://степень
                        Console.WriteLine("В разработке, ждите обновление");
                        Console.ReadKey();
                        Print();
                        break;
                    case ConsoleKey.D6:
                        break;
                    default:
                        Print();
                        break;
                }

            }
        }
    }
    interface IMath
    {
        static double Sum(double x, double y) => x + y;
        static double Mult(double x, double y) => x * y;
        static double Diff(double x, double y) => x - y;
        static double Div(double x, double y) => x / y;
        
        public delegate double Deleg(double x, double y);

        Deleg sum = Sum;
        Deleg mult = Mult;
        Deleg diff = Diff;
        Deleg div = Div;
        
    }
}