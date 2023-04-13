/*
С использованием делегата реализовать лямба-выражение для нахождения
> минимального
> максимального
> суммы
> произведения
> среднего арефметического
трёх члена
*/

namespace _13_04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            H h = new H();
            double v1, v2, v3;
            void Print()
            {
                v1 = Convert.ToDouble(Console.ReadLine());
                v2 = Convert.ToDouble(Console.ReadLine());
                v3 = Convert.ToDouble(Console.ReadLine());
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        h.min(v1, v2, v3);
                        break;
                    case ConsoleKey.D2:
                        h.max(v1, v2, v3);
                        break;
                    case ConsoleKey.D3:
                        h.sum(v1, v2, v3);
                        break;
                    case ConsoleKey.D4:
                        h.mult(v1, v2, v3);
                        break;
                    case ConsoleKey.D5:
                        h.aver(v1, v2, v3);
                        break;
                    default:
                        Print();
                        break;

                }
            }
            Print();
        }
    }
    class H
    {
        static double MIN(double v1, double v2, double v3) => Math.Min(Math.Min(v1, v2), Math.Min(v2, v3));
        static double MAX(double v1, double v2, double v3) => Math.Max(Math.Max(v1, v2), Math.Max(v2, v3));
        static double SUM(double v1, double v2, double v3) => v1 + v2 + v3;
        static double MULT(double v1, double v2, double v3) => v1 * v2 * v3;
        static double AVER(double v1, double v2, double v3) => (v1 + v2 + v3) / 3;

        public delegate double Delegate(double v1, double v2, double v3);
        public Delegate min = MIN;
        public Delegate max = MAX;
        public Delegate sum = SUM;
        public Delegate mult = MULT;
        public Delegate aver = AVER;
    }
}