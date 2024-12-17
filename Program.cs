using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    /// <summary>
    /// Задание 3. Создать список из целых чисел. Определить сумму значений 
    /// элементов списка, кратных 5.
    /// </summary>
    internal class Program
    {
        static void OutputList(List<int> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        static List<int> RandomList(int length, int min, int max)
        {
            List<int> list = new List<int>(length);
            Random rnd = new Random();

            for(int i = 0; i < length; i++)
            {
                list.Add(rnd.Next(min, max));
            }

            return list;
        }

        static void Main(string[] args)
        {
            List<int> list = RandomList(15, 0, 20);
            OutputList(list);

            int sum = list.Where(x => x % 5 == 0).Sum();

            Console.WriteLine($"Сумма значений элементов списка, кратных 5: {sum}");

            Console.ReadKey(true);
        }
    }
}
