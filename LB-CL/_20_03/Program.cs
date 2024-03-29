﻿/*
Array
ArrayList
Hashtable
SortedList
Stack - на вход подаётся строка, в которой присудствует круглая, квадратная, фигурная скобки, необходимо определить правильность открытия и закрытие скобок
Queue
List
Dictionary
SortedDictionary
HashSet
 */

using System.Collections;

namespace _20_03
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.Write(("<" + new string('_', 45) + "Меню" + new string('_', 45) + ">")
                + "\n1. Array"
                + "\n2. ArrayList"
                + "\n3. HashTable"
                + "\n4. SortedList"
                + "\n5. Stack"
                + "\n6. Queue"
                + "\n7. List"
                + "\n8. Dictionaty"
                + "\n9. SortedDictionaty"
                + "\n0. HashSet"
                + "\nE. Закрыть программу"
                + "\n-> ");
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    array();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    arraylist();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    hashtable();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    sorteblist();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    stack();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    queue();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    list();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    dictionary();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D9:
                    Console.Clear();
                    sorteddictionary();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    hashset();
                    Console.Write("Для возражения в меню нажмите \"E\"\n-> ");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.E:
                    break;
                default:
                    Main();
                    break;
            }
        }

        static public void array()
        {
            Console.WriteLine("<" + new string('_', 45) + "Array" + new string('_', 45) + ">");

            Array mas = Array.CreateInstance(typeof(string), 6);// 5 элементов типо стринг
            mas.SetValue("Dima", 0);
            mas.SetValue("Kate",1);
            mas.SetValue("Mr.Enot",2);
            mas.SetValue("En",3);
            mas.SetValue("Mr.Enot",4);
            mas.SetValue("Bekon",5);
            Console.WriteLine("Присваивает заданному элементу текущего массива Array заданное значение mas.SetValue(\"Bekon\",4)");
            Print();
            tere();

            Console.WriteLine("Возвращает значение указанного элемента в текущем массиве Array mas.GetValue(2) -> " + mas.GetValue(2));
            tere();

            Console.WriteLine("Выполняет поиск указанного объекта и возвращает индекс первого найденного совпадения в одномерном\nмассиве или диапазоне элементов массива mas.IndexOf(string, \"Mr.Enot\") -> " + Array.IndexOf(mas, "Mr.Enot"));
            tere();

            Console.WriteLine("Выполняет поиск с конца указанного объекта и возвращает индекс первого найденного совпадения в одномерном\nмассиве или диапазоне элементов массива Array.LastIndexOf(mas, \"Mr.Enot\") -> " + Array.LastIndexOf(mas, "Mr.Enot"));
            tere();

            Console.WriteLine("Копирование массива Array в тругой массив с определённого индекса mas.CopyTo(copy, 2)");
            string[] copy = new string[mas.Length * 2];
            mas.CopyTo(copy, 2);
            Console.WriteLine("Вывод массива cope");
            for (int i = 0; i < copy.Length; i++) { Console.WriteLine($"[{i}]: {copy[i]}"); }
            tere();

            Console.WriteLine("Сортирует массив Array по определённому смыслу Array.Sort(mas)");
            Array.Sort(mas);
            Print();
            tere();

            Console.WriteLine("Переворачивает массив Array.Reverse(mas)");
            Array.Reverse(mas);
            Print();
            tere();

            Console.WriteLine("Длина массива Array mas.Length -> " + mas.Length);
            tere();

            Console.WriteLine("Очищение всего массива Array ");
            Array.Clear(mas);
            Print();
            tere();
            

            void Print()
            {
                for (int i = 0; i <= mas.GetUpperBound(0); i++) { Console.WriteLine($"[{i}]: {mas.GetValue(i)}"); }
            }
            void tere()
            {
                Console.WriteLine("\n<" + new string('-', 100) + ">");
            }
        }

        static public void arraylist()
        {
            Console.WriteLine("<" + new string('_', 45) + "ArrayList" + new string('_', 45) + ">");

            ArrayList list = new ArrayList(); //могут храниться элементы разных типов
            string text = "";
            list.Add("Kate"); //Добавление элемента 
            list.Add(12);
            list.Add("Mr.Enot");
            list.Add(203);
            list.Add("123");
            list.Add("Kate");
            list.Add(321);
            list.Add("Dima");
            Print("/Добавление элемента list.Add(\"Kate\");");

            tere();
            Console.Write("Количество элементов list.Count " + list.Count);

            list.AddRange(new double[] { 2.3, 4.56 }); // добавление всех элементов массива в сипсок
            Print("Добавление всех элементов массива в сипсок list.AddRange(new double[] { 2.3, 4.56 })");

            list.Insert(2, "Ms.Kate"); // добавление элементо на определённое место
            Print("Добавление элемента на определённое место list.Insert(2, \"Ms.Kate\");");

            ArrayList slist = new ArrayList { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'C', '#' };
            list.InsertRange(list.Count, slist); // добавление ещё одного ArrayList slist в list
            Print("Добавление одного ArrayList slist в listlist.InsertRange(list.Count, slist);");

            tere();
            Console.Write("Нахождение элемента в ArrayList list начиная с начала:\nlist.IndexOf(\"Kate\") -> " + list.IndexOf("Kate"));

            tere();
            Console.Write("Нахождение элемента в ArrayList list начиная с конца:\nlist.LastIndexOf(\"Kate\") -> " + list.LastIndexOf("Kate"));

            list.Remove("Kate");//удаление 1-го элемнта
            Print("Удаление первого попавшегося определённого элемента list.Remove(\"Kate\")");

            list.RemoveAt(0);
            Print("Удаление элемента из ArrayList по его индексу list.RemoveAt(0);");

            list.RemoveRange(2, 2);
            Print("Удаление элементов с определённого индекса и количесво элементов после этого индекса list.RemoveRange(2, 2)");

            tere();
            Console.Write("Сoдержится ли элемент в списке (True/False) list.Contains(\"Dima\") ->" + list.Contains("Dima"));

            tere();
            Console.WriteLine("IEnumerator num = list.GetEnumerator();\r\nwhile (num.MoveNext())//шагает по листу пока не дайдёт до конца\r\n{\r\n\tConsole.Write(num.Current+\", \");//выводит элемент на которм стоит курсор\r\n}");
            IEnumerator num = list.GetEnumerator();
            while (num.MoveNext())//шагает по листу пока не дайдёт до конца
            {
                Console.Write(num.Current + ", ");//выводит элемент на которм стоит курсор
            }
            tere();

            void Print(string text)
            {
                tere();
                Console.WriteLine(text);
                foreach (var i in list) { Console.Write(i + " "); }
            }
            void tere()
            {
                Console.WriteLine("\n<" + new string('-', 100) + ">");
            }
        }

        static public void hashtable()
        {
            Console.WriteLine("<" + new string('-', 45) + "Hashtable" + new string('-', 45) + ">");
            Hashtable table = new Hashtable();

            table.Add(1, "Dima");
            table.Add(2, "Mr.Enot");
            table.Add(3, "Ms.Kat");
            table.Add(4, "Enot");

            tere();
            Console.WriteLine("Добавляет элемент с указанными ключом и значением в словарь Hashtable table.Add(4, \"Enot\")");
            Print();

            tere();
            Console.WriteLine("Определяет, содержит ли объект Hashtable указанный ключ table.ContainsKey(2) -> " + table.ContainsKey(2));
            Console.WriteLine("Определяет, содержит ли коллекция Hashtable указанное значение table.ContainsValue(\"Enot\") -> " + table.ContainsValue("Enot"));

            tere();
            var keyhash = new int[table.Count * 2];
            var valyehash = new string[table.Count * 2];
            Console.WriteLine("Копирует элементы коллекции Hashtable в экземпляр класса одномерного массива Array по указанному индексу");
            Console.Write("Массив ключей table.Keys.CopyTo(keyhash, 0) keyhash -> ");
            table.Keys.CopyTo(keyhash, 0);
            foreach (var m in keyhash) { Console.Write(m + ", "); }
            Console.Write("\nМассив объектов table.Values.CopyTo(valyehash, 0) valyehash -> ");
            table.Values.CopyTo(valyehash, 0);
            foreach (var m in valyehash) { Console.Write(m + ", "); }
            Console.WriteLine();

            //tere();
            //Console.WriteLine("Возвращает хэш-код указанного ключа table.GetHashCode(2) -> " + table.GetHash(2));

            //tere();
            //Console.WriteLine("Сравнивает указанный объект класса Object с указанным ключом, который содержится в коллекции Hashtable." + table.KeyEquals(1,1));

            tere();
            Console.WriteLine("Удаляет элемент с указанным ключом из Hashtable table.Remove(2)");
            table.Remove(2);
            Print();
            tere();

            void Print()
            {
                Console.WriteLine("Key\tValye"); 
                foreach (DictionaryEntry di in table) { Console.WriteLine($"{di.Key}:\t{di.Value}"); }
            }
            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
        }

        static public void sorteblist()
        {
            Console.WriteLine("<" + new string('_', 45) + "SortedList" + new string('_', 45) + ">");

            SortedList mySL = new SortedList();

            mySL.Add("two", "quick");
            mySL.Add("three", "brown");
            mySL.Add("four", "fox");
            mySL.Add("five", "Fox&Gox");

            Print();
            mySL.Add("one", "The");
            tere();
            Console.WriteLine("Добавляет элемент с указанными ключом и значением в объект mySL.Add(\"one\", \"The\");");
            Print();

            tere();
            Console.WriteLine("Получает ключ с указанным индексом из объекта mySL.GetKey(0) -> " + mySL.GetKey(0));

            tere();
            Console.WriteLine("Получает значение с указанным индексом из объекта mySL.GetByIndex(0) -> " + mySL.GetByIndex(0));

            tere();
            Console.WriteLine("Определяет, содержит ли объект SortedList указанный ключ mySL.Contains(two) -> " + mySL.Contains("two"));

            tere();
            Console.WriteLine("Определяет, содержит ли объект SortedList указанный ключ mySL.ContainsKey(\"four\") -> " + mySL.ContainsKey("four"));

            tere();
            Console.WriteLine("Определяет, содержит ли объект SortedList указанное значение mySL.ContainsValue(\"brown\") -> " + mySL.ContainsValue("brown"));

            tere();
            IList myKeyList = mySL.GetKeyList();//список всех ключей 
            IList myValueList = mySL.GetValueList();//список всех значений
            Console.WriteLine("Cписок всех ключей IList myKeyList = mySL.GetKeyList()");
            for (int i = 0; i < mySL.Count; i++)
                Console.WriteLine($"myKeyList[{i}] -> {myKeyList[i]}");
            Console.WriteLine("Cписок всех значений IList myValueList = mySL.GetValueList()");
            for (int i = 0; i < mySL.Count; i++)
                Console.WriteLine($"myValueList[{i}] -> {myValueList[i]}");

            tere();
            Console.WriteLine("-INDEX-\t-KEY-\t-VALUE-");
            for (int i = 0; i < mySL.Count; i++)
                Console.WriteLine($"[{i}]:\t{mySL.GetKey(i)}\t{ mySL.GetByIndex(i)}");
            Console.WriteLine("Возвращает индекс (с нуля) указанного ключа в объекте SortedList mySL.IndexOfKey(\"there\") -> " + mySL.IndexOfKey("three"));
            Console.WriteLine("Индекс (с нуля) первого вхождения указанного значения в объекте SortedList mySL.IndexOfValue(\"brown\") -> " + mySL.IndexOfValue("brown"));

            tere();
            Console.WriteLine("Удаляет элемент с указанным ключом из объекта SortedList mySL.Remove(\"three\")");
            mySL.Remove("three");
            for (int i = 0; i < mySL.Count; i++)
                Console.WriteLine($"[{i}]:\t{mySL.GetKey(i)}\t{mySL.GetByIndex(i)}");

            tere();
            Console.WriteLine("Удаляет элемент с указанным индексом из объекта SortedList mySL.RemoveAt(mySL.IndexOfValue(\"Fox&Gox\"));");
            mySL.RemoveAt(mySL.IndexOfValue("Fox&Gox"));
            for (int i = 0; i < mySL.Count; i++)
                Console.WriteLine($"[{i}]:\t{mySL.GetKey(i)}\t{mySL.GetByIndex(i)}");

            tere();
            Console.WriteLine("Заменяет значение по указанному индексу в объекте SortedList mySL.SetByIndex(mySL.IndexOfKey(\"one\"), \"million\")");
            mySL.SetByIndex(mySL.IndexOfKey("one"), "million");
            for (int i = 0; i < mySL.Count; i++)
                Console.WriteLine($"[{i}]:\t{mySL.GetKey(i)}\t{mySL.GetByIndex(i)}");

            tere();


            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
            void Print()
            {
                tere();
                for(int i = 0; i<mySL.Count; i++)
                {
                    Console.WriteLine($"{mySL.GetKey(i)}: {mySL.GetByIndex(i)}");
                }
            }
        }

        static public void stack()
        {
            Console.WriteLine("<" + new string('_', 45) + "Stack" + new string('_', 45) + ">");
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Добавляет элемент в стек в верхушку стека stack.Push(5)");
            foreach(var s in stack) Console.WriteLine(s);

            tere();
            Console.WriteLine("Проверяет наличие в стеке элементов и возращает True при его налиичи stack.Contains(3) -> " + stack.Contains(3));

            tere();
            Console.WriteLine("Возращает первый элемент из стека без его удаления stack.Peek() -> " + stack.Peek());

            tere();
            Console.WriteLine("Извлекает и возращает первый элемент из стека stack.Pop() -> " + stack.Pop());
            foreach (var s in stack) Console.WriteLine(s);

            tere();
            int[] ar = new int[stack.Count * 2];
            stack.CopyTo(ar, 2);
            Console.WriteLine("Копирует Stack<T> в существующий одномерный Array,\nначиная с указанного индекса массива stack.CopyTo(ar, 2);");
            Console.Write("Вывод массива ar: ");
            foreach(var a in ar) Console.Write(a + ", ");
            Console.WriteLine();

            //ToArray - ?

            tere();
            //int result;
            //stack.TryPeek(result);
            Console.WriteLine("Возвращает значение, указывающее, имеется ли в верхней части Stack<T> объект,\nи если он присутствует, копирует его в параметр result. Объект не удаляется из Stack<T> "
                + stack.TryPeek(out var result1) + " -> " + result1);

            tere();
            //stack.TryPop(result);
            Console.WriteLine("Возвращает значение, указывающее, имеется ли в верхней части Stack<T> объект,\nи если он присутствует, копирует его в параметр result и удаляет из Stack<T> " 
                + stack.TryPop(out var result2) + " -> " + result2);
            foreach (var s in stack) Console.WriteLine(s);

            tere();
            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
        }

        static public void queue()
        {
            Console.WriteLine("<" + new string('_', 45) + "Queue" + new string('_', 45) + ">");
            Queue<string> queue = new Queue<string>();

            tere();
            Console.WriteLine("Добавляет объект в конец коллекции Queue queue.Enqueue(\"Dima\")");
            queue.Enqueue("Dima");
            queue.Enqueue("Kate");
            queue.Enqueue("En");
            queue.Enqueue("Adidas");
            queue.Enqueue("Dima");

            foreach (var a in queue) { Console.WriteLine(a); }

            tere();
            Console.WriteLine("Определяет, входит ли элемент в коллекцию Queue queue.Contains(\"En\") -> " + queue.Contains("En"));

            tere();
            string[] array = new string[queue.Count * 2];
            queue.CopyTo(array, 2);
            Console.WriteLine("Копирует элементы коллекции Queue в существующий одномерный массив Array,\nначиная с указанного значения индекса массива queue.CopyTo(array, 2)\nВывод массива array");
            for(int i =0; i<array.Length; i++) { Console.WriteLine($"[{i}]: {array[i]}"); }


            tere();
            Console.WriteLine("Удаляет объект из начала очереди Queue и возвращает его queue.Dequeue() -> " + queue.Dequeue());
            foreach (var a in queue) { Console.WriteLine(a); }

            //IEnumerator enumerator = queue.GetEnumerator();//Возвращает перечислитель, осуществляющий перебор элементов списка Queue.
            //while (enumerator.MoveNext()) { Console.WriteLine(enumerator.Current); }

            tere();
            Console.WriteLine("Возвращает объект, находящийся в начале очереди Queue, но не удаляет его queue.Peek() -> " + queue.Peek());

            tere();
            string[] array2 = queue.ToArray();
            Console.WriteLine("Копирует элементы Queue в новый массив string[] array2 = queue.ToArray()\nВывод массива array2");
            for (int i = 0; i < array2.Length; i++) { Console.WriteLine($"[{i}]: {array2[i]}"); }

            tere();
            Console.WriteLine("bool TryDequeue(out T result): передает в переменную result первый элемент очереди с\nего удалением из очереди, возвращает true, если очередь не пуста и элемент успешно получен.");
            Console.WriteLine("bool TryPeek(out T result): передает в переменную result первый элемент очереди без\nего извлечения из очереди, возвращает true, если очередь не пуста и элемент успешно получен.");
            tere();

            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
        }

        static public void list()
        {
            List<string> list = new List<string>();
            Console.WriteLine("<" + new string('_', 45) + "List" + new string('_', 45) + ">");

            list.Add("Dima");
            list.Add("Nosok");
            list.Add("Nuke");
            list.Add("Jon");
            list.Add("Enotik");
            tere();
            Console.WriteLine("Добавляет объект в конец коллекции List<T> list.Add(\"Enotik\")");
            Print();

            tere();
            List<string> dinosaurs = new List<string> { "Brachiosaurus", "Amargasaurus", "Mamenchisaurus" };
            list.AddRange(dinosaurs);
            Console.WriteLine("Добавляет элементы указанной коллекции в конец списка List<T> list.AddRange(dinosaurs)");
            Print();

            tere();
            string[] array1 = list.GetRange(3, 5).ToArray();
            Console.WriteLine("Создает неполную копию диапазона элементов исходного списка List<T> string[] array1 = list.GetRange(3, 5).ToArray()\nВывод массива array1");
            for(int i =0; i < array1.Length; i++) { Console.WriteLine($"[{i}]: { array1[i]}"); }

            tere();
            Console.WriteLine("Вставляет элемент в коллекцию List<T> по указанному индексу list.Insert(6, \"Nuke\")");
            list.Insert(7, "Nuke");
            Print();

            tere();
            Console.WriteLine("Возвращает отсчитываемый от нуля индекс первого вхождения значения в списке List<T> или в его части"
                + "\nlist.IndexOf(\"Nuke\") -> " + list.IndexOf("Nuke")
                + "\nlist.IndexOf(\"Nuke\", 5) -> " + list.IndexOf("Nuke", 5));

            tere();
            List<string> list2 = new List<string> { "Beka", "Akeb" };
            list.InsertRange(3, list2);
            Console.WriteLine("Вставляет элементы коллекции в список List<T> в позиции с указанным индексом list.InsertRange(3, list2)");
            Print();

            tere();
            Console.WriteLine("Возвращает отсчитываемый от нуля индекс последнего вхождения значения в списке List<T> или в его части"
                + "\nlist.LastIndexOf(\"Nuke\") -> " + list.LastIndexOf("Nuke")
                + "\nlist.LastIndexOf(\"Nuke\", 5)" + list.LastIndexOf("Nuke", 5));

            tere();
            Console.WriteLine("Удаляет первое вхождение указанного объекта из коллекции List<T> list.Remove(\"Nuke\")");
            list.Remove("Nuke");
            Print();

            tere();
            Console.WriteLine("Удаляет элемент списка List<T> с указанным индексом list.RemoveAt(0)");
            list.RemoveAt(0);
            Print();

            tere();
            Console.WriteLine("Удаляет диапазон элементов из списка List<T> list.RemoveRange(0, 5)");
            list.RemoveRange(0, 5);
            Print();

            tere();
            Console.WriteLine("Изменяет порядок элементов в списке List<T> или в его части на обратный list.Reverse()");
            list.Reverse(); //Reverse(Int32, Int32)	Изменяет порядок элементов в указанном диапазоне.
            Print();

            tere();
            Console.WriteLine("Сортирует элементы во всем списке List<T> с помощью функции сравнения по умолчанию list.Sort()");
            list.Sort();
            Print();

            tere();
            Console.WriteLine("Копирует элементы списка List<T> в новый массив var array2 = list.ToArray()");
            var array2 = list.ToArray();
            Console.WriteLine("Вывод массива array2 ");
            for (int i = 0; i < array2.Length; i++) { Console.WriteLine($"[{i}]: {array2[i]}"); }

            tere();
            
            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
            void Print()
            {
                foreach (var a in list) { Console.WriteLine(a); }
            }
        }

        static public void dictionary()
        {
            Console.WriteLine("<" + new string('_', 45) + "Dictionary" + new string('_', 45) + ">");
            Dictionary<string, string> dic = new Dictionary<string, string>();

            tere();
            dic.Add("Dictionary", "Словарь");
            dic.Add("List", "Список");
            dic.Add("Stack", "Стек");
            dic.Add("Queue", "Очередь");
            dic.Add("Array", "Массив");
            Console.WriteLine("Добавляет указанные ключ и значение в словарь dic.Add(\"Array\", \"Массив\")");
            Print();

            tere();
            Console.WriteLine("Определяет, содержится ли указанный ключ в словаре dic.ContainsKey(\"List\") -> " + dic.ContainsKey("List"));
            Console.WriteLine("Определяет, содержит ли коллекция Dictionary<TKey,TValue> указанное значение \ndic.ContainsValue(\"Стек\") -> " + dic.ContainsValue("Стек"));

            tere();
            Console.WriteLine("Удаляет по ключу элемент из словаря dic.Remove(\"List\")");
            dic.Remove("List");
            Print();

            tere();
            Console.WriteLine("Получает из словаря элемент по ключу key. При успешном получении передает значение элемента в выходной\nпараметр value и возвращает true dic.TryGetValue(\"Stack\", out string result) -> "
                + dic.TryGetValue("Stack", out string result) + " result -> " + result);

            tere();
            Console.WriteLine("Добавляет в словарь элемент с ключом key и значением value.\nПри успешном добавлении возвращает true dic.TryAdd(\"List\", \"Список\") -> " + dic.TryAdd("List", "Список"));
            Print();
            tere();
            
            void Print()
            {
                foreach(var d in dic) { Console.WriteLine($"Key: {d.Key} => Value: {d.Value}"); }
            }
            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
        }

        static public void sorteddictionary()
        {
            Console.WriteLine("<" + new string('_', 45) + "SortedDictionary" + new string('_', 45) + ">");

            SortedDictionary<string, string> sd = new SortedDictionary<string, string>();

            tere();
            Console.WriteLine("Добавляет элемент с указанными ключом и значением в словарь");
            sd.Add("Dictionary", "Словарь");
            sd.Add("List", "Список");
            sd.Add("Stack", "Стек");
            sd.Add("Queue", "Очередь");
            sd.Add("Array", "Массив");
            Print();

            tere();
            Console.WriteLine("Определяет, содержится ли элемент с указанным ключом в SortedDictionary<TKey,TValue>\nsd.ContainsKey(\"Stack\") -> " + sd.ContainsKey("Stack"));
            Console.WriteLine("Определяет, содержится ли элемент с указанным значением в словаре SortedDictionary<TKey,TValue>\nsd.ContainsValue(\"Что-то\") ->" + sd.ContainsValue("Что-то"));

            tere();
            Console.WriteLine("Удаляет элемент с указанным ключом из объекта SortedDictionary<TKey,TValue> sd.Remove(\"Stack\")");
            sd.Remove("Stack");
            Print();

            tere();
            Console.WriteLine("Получает значение, связанное с заданным ключом sd.TryGetValue(\"Array\") ->" + sd.TryGetValue("Array", out string result) + " result -> " + result);
            

            void Print()
            {
                foreach (var d in sd) { Console.WriteLine($"Key: {d.Key} => Value: {d.Value}"); }
            }
            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
        }

        static public void hashset()
        {
            Console.WriteLine("<" + new string('_', 45) + "HashSet" + new string('_', 45) + ">");

            HashSet<string> hash = new HashSet<string>();

            tere();
            hash.Add("Apple");
            hash.Add("Samsung");
            hash.Add("Apple");
            hash.Add("Huawe");
            hash.Add("Mi");
            Console.WriteLine("Добавляет указанный элемент в набор hash.Add(\"Huawe\")");
            foreach (var s in hash) { Console.WriteLine(s); }

            tere();
            Console.WriteLine("Определяет, содержит ли объект HashSet<T> указанный элемент hash.Contains(\"Apple\") -> " + hash.Contains("Apple"));

            tere();
            Console.WriteLine("Копирует элементы объекта HashSet<T> в массив, начиная с указанного индекса массива hash.CopyTo(mas, 1)");
            var mas = new string[hash.Count*2];
            hash.CopyTo(mas, 1);
            Console.WriteLine("Вывод массива mas");
            for(int i = 0; i < mas.Length; i++){ Console.WriteLine($"[{i}]: {mas[i]}"); }

            tere();
            HashSet<string> list = new HashSet<string> { "Apple", "Nuke", "Mi", "Joom" };
            Console.WriteLine("Удаляет все элементы в указанной коллекции из текущего объекта HashSet<T> hash.ExceptWith(list");
            Console.WriteLine("list: Apple, Nuke, Mi, Joom");
            foreach (var l in hash) { Console.Write(l + ", "); }
            hash.ExceptWith(list);
            Console.Write(" --> ");
            foreach (var l in hash) { Console.Write(l + ", "); }
            Console.WriteLine();

            tere();
            hash.Add("Mi");
            hash.Add("Apple");
            Console.WriteLine("Изменяет текущий объект HashSet<T> так, чтобы он содержал только элементы, которые имеются в этом\nобъекте и в указанной коллекции hash.IntersectWith(list)");
            Console.WriteLine("list: Apple, Nuke, Mi, Joom");
            foreach (var l in hash) { Console.Write(l + ", "); }
            hash.IntersectWith(list);
            Console.Write(" --> ");
            foreach (var l in hash) { Console.Write(l + ", "); }
            Console.WriteLine();
            
            tere();
            hash.Add("Mi");
            hash.Add("Apple");
            Console.WriteLine("Определяет, является ли объект HashSet<T> подмножеством указанной коллекции\nhash.IsSubsetOf(list) -> " + hash.IsSubsetOf(list));
            Console.WriteLine("\nОпределяет, является ли объект HashSet<T> супермножеством указанной коллекции\nhash.IsSupersetOf(list) -> " + hash.IsSupersetOf(list));
            Console.WriteLine("\nОпределяет, имеются ли общие элементы в текущем объекте HashSet<T> и в указанной коллекции\nhash.Overlaps(list) -> " + hash.Overlaps(list));
            Console.WriteLine("\nОпределяет, содержат ли объект HashSet<T> и указанная коллекция одни и те же элементы -> " + hash.SetEquals(list));
            Console.WriteLine("list: Apple, Nuke, Mi, Joom");
            foreach (var l in hash) { Console.Write(l + ", "); }
            Console.WriteLine();

            tere();
            Console.WriteLine("Удаляет указанный элемент из объекта HashSet<T> hash.Remove(\"Mi\")");
            hash.Remove("Mi");
            foreach (var l in hash) { Console.Write(l + ", "); }
            Console.WriteLine();

            tere();
            Console.WriteLine("Изменяет текущий объект HashSet<T> так, чтобы он содержал только элементы, которые имеются либо в этом\nобъекте, либо в указанной коллекции, но не одновременно в них обоих");
            Console.Write("hash до: ");
            foreach (var l in hash) { Console.Write(l + ", "); }
            Console.Write("\nlist: ");
            foreach (var l in list) { Console.Write(l + ", "); }
            hash.SymmetricExceptWith(list);
            Console.Write("\n hash после: ");
            foreach (var l in hash) { Console.Write(l + ", "); }
            Console.WriteLine();

            tere();

            void tere()
            {
                Console.WriteLine("<" + new string('-', 100) + ">");
            }
        }
    }
}