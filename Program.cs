using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    /// <summary>
    /// Задание 4. Создать список из целых чисел. Вставить в список число 10 
    /// после каждого элемента с отрицательным значением.
    /// </summary>
    internal class Program
    {
        static int Size()
        {
            Console.Write("Размер списка: ");
            int size;
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Ошибка");
            }
            return size;
        }

        static void OutputList(List<int> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        static List<int> InitialList(int length)
        {
            List<int> list = new List<int>(length);
            for(int i = 0; i < length; i++)
            {
                Console.Write($"list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            return list;
        }

        static void Insert10(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Insert(i + 1, 10);
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> list = InitialList(Size());
            OutputList(list);

            Insert10(list);
            OutputList(list);

            Console.ReadKey(true);
        }
    }
}
