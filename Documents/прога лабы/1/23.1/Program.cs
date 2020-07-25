using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._1
{
    class Program
    {
        static int Main(string[] args)
        {
            int i;
            Console.Write("Введите положительное число содержащее больше 5 разрядов: ");
            string num = Console.ReadLine();
            for (i = 0; i < ((num.Length / 2)); i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    Console.WriteLine($"Число {num} не является полиндромом");
                    Console.ReadKey();
                    return 0;
                }
                //Console.WriteLine($"{num[i]} == {num[num.Length - i - 1]}");
            }
            Console.WriteLine($"Число {num} является полиндромом");
            Console.ReadKey();
            return 0;
        }
    }
}
