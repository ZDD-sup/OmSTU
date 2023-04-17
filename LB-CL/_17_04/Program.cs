namespace _17_04
{
    public delegate void EventDelegate(double x, double y);

    public class MyEvent
    {
        public event EventDelegate myEvent;

        public void Invoke(double x, double y)
        {
            myEvent.Invoke(x, y);
        }
    }

    internal class Program
    {
        static public void Sum(double x, double y) => Console.WriteLine(x + y);
        static public void Diff(double x, double y) => Console.WriteLine(x - y);
        static public void Mult(double x, double y) => Console.WriteLine(x * y);
        static public void Div(double x, double y) => Console.WriteLine(x / y);

        static void Main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            MyEvent cal = new MyEvent();
            cal.myEvent += new EventDelegate(Sum);
            cal.myEvent += Diff;
            cal.myEvent += Mult;
            cal.myEvent += Div;


            cal.Invoke(x, y);
            Console.ReadKey();
        }
    }
}