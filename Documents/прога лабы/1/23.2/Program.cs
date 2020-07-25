using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._2
{
    class Program
    {
        static string ReadNumFromLine(string str,out double a)
        {
            int i=0,count=0;
            string num=" ";
            char[] res=new char[100];
            str.CopyTo(0,res,0,str.Length);
            while (((str[i] >= 48) && (str[i] <= 57)) || (str[i] == 45) || (str[i] == '.'))
            {
                num = num + Convert.ToString(str[i]);
                count++;
                i++;
            }
            while ((str[i] < 48) && (str[i] > 57))
            { 
                count++;
                i++;
            }
            for (i = 0; i <= count; i++)
                for (int j = 1; j < res.Length; j++)
                    res[j - 1] = res[j];
            res[res.Length-1] = '\0';
            str = str.Substring(str.Length);
            for (i = 0; i < res.Length; i++)
                str = str + Convert.ToString(res[i]);
            a = Convert.ToDouble(num);
            return str;
        }

        static void input(double[,] dat)
        {
            double a;
            string str;
            for (int i = 0; i < 5; i++)
            {
                str = Console.ReadLine();
                for (int j = 0; j < 5; j++)
                {
                    str=ReadNumFromLine(str,out a);
                    dat[i, j] = a;
                    
                }
            }
        }

        static void output(double[,] dat)
        {
            Console.WriteLine();
            for(int i=0;i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write($"{dat[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static double FindMaxUperDig(double[,] dat)
        {
            double max;
            max = dat[0, 1];
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 5; j++)
                    if (max <= dat[i, j])
                        max = dat[i, j];
            return max;
        }

        static double FindMinLowerDig(double[,] dat)
        {
            double min;
            min = dat[1, 0];
            for (int i = 1; i < 5; i++)
                for (int j = 0; j < i; j++)
                    if (min >= dat[i, j])
                        min = dat[i, j];
            return min;
        }

        static void ChangePlace(double el1, double el2, double[,] dat)
        {
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 5; j++)
                    if(el1==dat[i,j])
                        dat[i, j] = el2;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < i ; j++)
                    if (el2 == dat[i, j])
                        dat[i, j] = el1;


        }

        static void Main(string[] args)
        {
            double[,] dat = new double[5, 5];
            int m, n;
            input(dat);
            //output(dat);
            //Console.WriteLine($"Максимальный элемент лежащий  выше главной диагонали == {FindMaxUperDig(dat)}");
            //Console.WriteLine($"Минимальный элемент лежащий  вниже главной диагонали == {FindMinLowerDig(dat)}");
            ChangePlace(FindMaxUperDig(dat), FindMinLowerDig(dat),dat);
            output(dat);
            Console.ReadLine();
        }
    }
}
