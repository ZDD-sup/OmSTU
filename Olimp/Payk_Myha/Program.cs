namespace Payk_Myha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Sx, Sy, Sz, Fx, Fy, Fz, result;
            //a - ширина b - глубина(длина) c - высота
            string path = "D:/OmSTU/Olimp/Payk_Myha/Payk_and_Myha/input_s1_03.txt";
            using (StreamReader  sr = new StreamReader(path))
            {
                string[] line = sr.ReadLine().Split(new char[] { ' ' });
                A = int.Parse(line[0]);
                B = int.Parse(line[1]);
                C = int.Parse(line[2]);
                line = sr.ReadLine().Split(new char[] { ' ' });
                Sx = int.Parse(line[0]);
                Sy = int.Parse(line[1]);
                Sz = int.Parse(line[2]);
                line = sr.ReadLine().Split(new char[] { ' ' });
                Fx = int.Parse(line[0]);
                Fy = int.Parse(line[1]);
                Fz = int.Parse(line[2]);
            }
            // Расстояние по оси X
            double dx = Math.Abs(Fx - Sx);
            if (dx > A / 2)
            {
                dx = A - dx;
            }

            // Расстояние по оси Y
            double dy = Math.Abs(Fy - Sy);
            if (dy > C / 2)
            {
                dy = C - dy;
            }

            // Расстояние по оси Z
            double dz = Math.Abs(Fz - Sz);
            if (dz > C / 2)
            {
                dz = C - dz;
            }

            // Вычисление расстояния между пауком и мухой
            double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);

            Console.WriteLine("{0:F3}", distance);
            Console.ReadKey();
        }
    }
}