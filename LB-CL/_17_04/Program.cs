namespace _17_04
{
    internal class Program
    {
        static void Main()
        {

        }
    }
    class Ac
    {
        public delegate void Deleg(double x, double y);
        public double Sum(double x, double y) => x + y;
        public double Diff(double x, double y) => x - y;
        public double Mult(double x, double y) => x * y;
        public double Div(double x, double y) => x / y;


    }
}