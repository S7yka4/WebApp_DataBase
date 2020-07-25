using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static string ReadNumFromLine(string str, out double a)
        {
            int i = 0, count = 0;
            string num = "";
            char[] res = new char[100];
            str.CopyTo(0, res, 0, str.Length);
            while (((str[i] >= 48) && (str[i] <= 57)) || (str[i] == 45) || (str[i] == '.'))
            {
                num = num + Convert.ToString(str[i]);
                count++;
                i++;
            }
            while (((str[i] < 48) || (str[i] > 57)) && (str[i] != 45) && (str[i] != '\0'))
            {
                count++;
                i++;
            }
            for (i = 0; i < count; i++)
                for (int j = 1; j < res.Length; j++)
                    res[j - 1] = res[j];
            res[res.Length - 1] = '\0';
            str = str.Substring(str.Length);
            for (i = 0; i < res.Length; i++)
                str = str + Convert.ToString(res[i]);
            if (num.Length > 0)
                a = Convert.ToDouble(num);
            else
            {
                Console.WriteLine($"Ошибка при str={str}!" + $"res={res}!" + $"num={num}!");
                a = 0;
            }
            return str;
        }


        static double summy(double[,] dat,int j)
        {
            int i;
            double res=0;
            for (i = 0; i < 4; i++)
                res = res + dat[i,j];
            return res;
        }

        static double summx(double[,] dat, int i)
        {
            int j;
            double res = 0;
            for (j = 0; j < 6; j++)
                res = res + dat[i, j];
            return res;
        }

        static void Main(string[] args)
        {
            int i, j,m;
            string str;
            double[,] dat = new double[4,6];
            double res;
            for (i = 0; i < 4; i++)
            {
                str = Console.ReadLine();
                for (j = 0; j < 6; j++)
                {
                    str = ReadNumFromLine(str, out res);
                    dat[i, j] = res;
                }
            }
           /* for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 6; j++)
                    Console.Write($"{dat[i,j]} ");
                Console.WriteLine();
            }*/
            res = summy(dat,0);
            m = 0;
            for (j = 1; j < 6; j++)
               if (res <= summy(dat, j))
                {
                    res = summy(dat, j);
                    m = j;
                }
            Console.WriteLine($"Номер столбца с максимальной суммой == {m+1}\n");
            res = summx(dat, 0);
            m = 0;
            for (i = 1; i < 4; i++)
                if (res >= summx(dat, i))
                {
                    res = summx(dat, i);
                    m = i;
                }
            Console.WriteLine($"Номер строки с минимальной суммой == {m+1}\n");
            Console.ReadLine();


        }
    }
}
