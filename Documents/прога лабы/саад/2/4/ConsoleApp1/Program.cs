using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void input(List<VipAcc> List)
        {
            Random rnd = new Random();
            int n = rnd.Next(5,10);
            for (int i = 0; i < n; i++)
                List.Add(new VipAcc(rnd.Next(1,100), rnd.Next(1,1000000), rnd.Next(1,15), new DateTime(2020 - rnd.Next(1, 10), 4 + rnd.Next(1, 8), 10 + rnd.Next(1, 10)),rnd.Next()));
        }
        static void output(List<VipAcc> List)
        {
            foreach (var ptr in List)
                ptr.Output();
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<VipAcc> BanckAccs = new List<VipAcc>();
            input(BanckAccs);

             output(BanckAccs);
            foreach (var ptr in BanckAccs)
                //Console.WriteLine($"{ptr.Computation(new DateTime(2020 + rnd.Next(1, 10), 4 + rnd.Next(1, 8), 10 + rnd.Next(1, 10)))}");
                ptr.EstimatedAmount(rnd.Next(1, 10000), new DateTime(2020 + rnd.Next(1, 4), 4 + rnd.Next(1, 8), 10 + rnd.Next(1, 10)));
        }
    }
}
