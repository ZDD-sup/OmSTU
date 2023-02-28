namespace Payk_Myha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Sx, Sy, Sz, Fx, Fy, Fz, result;

            string path = "D:/OmSTU/Olimp/Payk_Myha/Паук и муха/input_s1_03.txt";
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
            if (Sx == Fx)
                result = Math.Abs(Sx - Fx);
            else if (Sy == Fy)
                result = Math.Abs(Sy - Fy);
            else if (Sz == Fz)
                result = Math.Abs(Sz - Fz);
            else
            {
                
            }
            Console.WriteLine($"{result:#.###}");
            Console.ReadKey();
        }
    }
}