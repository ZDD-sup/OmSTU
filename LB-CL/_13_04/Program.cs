namespace _13_04
{
    internal class Program
    {
        static void Main()
        {
            double x, y;

            Print_start();
            void Print_start()
            {
                Console.Clear();
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1. Сумма"
                    + "\n2. Разница"
                    + "\n3. Умножение"
                    + "\n4. Деление");
                void Print()
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            break;
                        case ConsoleKey.D3:
                            break;
                        case ConsoleKey.D4:
                            break;
                        default:
                            Print();
                            break;
                    }

                }
            }
        }
    }
    class Math : IMath
    {
        public delegate double Deleg(double x, double y);

        public void Sum(double x, double y)
        { 
            Console.WriteLine(x + y);
        }
        public void Mult(double x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void Diff(double x, double y)
        {
            Console.WriteLine(x - y);
        }
        public void Div(double x, double y)
        {
            Console.WriteLine(x / y);
        }

        Deleg sum = Sum;
        Deleg mult = Mult;
        Deleg diff = Diff;
        Deleg div = Div;
    }
    interface IMath
    {
        static double Sum(double x, double y);
        static double Mult(double x, double y);
        static double Diff(double x, double y);
        static double Div(double x, double y);
    }
}