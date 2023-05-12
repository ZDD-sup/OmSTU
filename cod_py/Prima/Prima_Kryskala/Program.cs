namespace Prima_Kryskala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество вершин");
            int N = Convert.ToInt32(Console.ReadLine());
            List<int> dug = new List<int> {2, 2, 2, 2, 5, 7, 10, 9, 9, 2, 17, 16, 5, 17};
            List<string> dug_name = new List<string> {"ac", "ab", "bc", "be", "ce", "ae", "ed", "eg", "bd", "dg", "gh", "dh", "df", "fh"};
            string spisok = "", name;
            int sum = 0, count = 0, i, min;
            N = 8;
            //do
            //{
            //    Console.Write("Укажите две вершины соедмиинённые дугой: ");
            //    dug_name.Add(Convert.ToString(Console.ReadLine()));
            //    Console.Write("Укажите днину дуги: ");
            //    dug.Add(Convert.ToInt32(Console.ReadLine()));
            //    Console.Write("Ещё есть дуга?(1 - Да / 2 - Нет)\n->");
            //} while (Convert.ToString(Console.ReadLine()) == "1");

            //Inf();
            //void Inf()
            //{
            //    i = dug.IndexOf(dug.Min());
            //    min = dug[i];
            //    name = dug_name[i];
            //    Def();
            //}
            Def();
            int MIN()
            {
                int m = dug[0];
                foreach (int i in dug)
                {
                    if (i < m) m = i;
                }
                return m;
            }
            void Def()
            {
                min = MIN();
                i = dug.IndexOf(min);
                name = dug_name[i];
                if ((spisok.Contains(name[0]) || spisok.Contains(name[1])) && !(spisok.Contains(name[0]) && spisok.Contains(name[1])))
                {
                    sum += min;
                    dug.RemoveAt(i);
                    dug_name.RemoveAt(i);
                    count++;
                    if (spisok.Contains(name[0]))
                        spisok += name[1];
                    else
                        spisok += name[0];
                }
                else if (spisok.Contains(name[0]) && spisok.Contains(name[1]))
                {
                    dug.RemoveAt(i);
                    dug_name.RemoveAt(i);
                }
                if (count == N || dug.Count == 0)
                    Console.WriteLine($"Минимальная длина графа равна {sum}, следоание {spisok}");
                else
                    Def();
            }
        }
    }
}