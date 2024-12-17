using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    /// <summary>
    /// Задание 2. Записана информация о стоимости каждого из 20 видов товара, 
    /// продаваемых фирмой. С 1 января очередного года фирма прекращает 
    /// продавать товар, стоимость которого записана в n-м элементе списка. 
    /// Получить список со стоимостью всех оставшихся видов товара.
    /// </summary>
    internal class Program
    {
        static void OutputList(List<double> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var costs = new List<double>()
            {
                10, 20.5, 14, 8, 3.40, 9, 5.50, 38, 15, 20.5,
                3.5, 29.9, 32, 43, 42.5, 7.8, 9.9, 12, 93, 50
            };

            OutputList(costs);

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            costs.RemoveAt(n);
            OutputList(costs);

            Console.ReadKey(true);
        }
    }
}
