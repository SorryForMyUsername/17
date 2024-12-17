using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    /// <summary>
    /// Задание 1. Создайте коллекцию (согласно варианту) из шести элементов:
    /// </summary>
    internal class Program
    {
        static void OutputList(List<string> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        static void ToUpperList(List<string> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToUpper();
            }
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>(6);
            //List<string> people = new List<string>() { "Илья", "Андрей", "Елена"};
            //var people1 = new List<string>() { "Антон", "Надежда", "Николай" };
            //var people2 = new List<string>(people1);
            //OutputList(list);
            //OutputList(people);
            //OutputList(people1);
            //OutputList(people2);
            list.Add("елена");
            list.Add("надежда");
            list.Add("екатерина");
            list.Add("елизавета");
            list.Add("виктория");
            list.Add("полина");
            OutputList(list); //2)

            ToUpperList(list); //3)
            OutputList(list); //4)

            Console.WriteLine($"Количество элементов в коллекции: {list.Count}\n"); //5)

            list.Add("александра"); //6)
            OutputList(list); //7)

            list.Insert(0, "галина"); //8)
            OutputList(list); //9)

            list.RemoveAt(3); //10)
            OutputList(list); //11)

            list.Reverse(); //12)
            OutputList(list);

            Console.ReadKey(true);
        }
    }
}
