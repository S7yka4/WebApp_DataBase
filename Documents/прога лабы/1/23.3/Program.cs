using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._3
{
    class Program
    {
        struct Height
        {
           public string name;
           public double height;

            public Height(string n,double h)
            {
                name = n;
                height = h;
            }

            public void output()
            {
                Console.WriteLine($"Фамилия: {name}");
                Console.WriteLine($"Рост: {height}см");
            }
        }

        static double FindMid(List<Height> Stat)
        {
            double res=0;
            int i=0;
            foreach(Height ptr in Stat)
            {
                i++;
                res = res + ptr.height;
            }
            return res / i;

        }
        static void Main(string[] args)
        {
            List<Height> Stat = new List<Height>();
            string str;
            double a;
            Console.WriteLine("Введите '.' для того, чтобы закончить заполнение списка");
            Console.Write("Введите фамилию: ");
            str = Console.ReadLine();
            while(str!=".")
            {
                Console.Write("Введите рост: ");
                a = Convert.ToDouble(Console.ReadLine());
                Stat.Add(new Height(str, a));
                Console.Write("Введите фамилию: ");
                str = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Люди с ростом выше среднего");
            foreach (Height ptr in Stat.Where(ptr => (ptr.height > FindMid(Stat))))
                ptr.output();
            Console.ReadLine();
        }
    }
}
