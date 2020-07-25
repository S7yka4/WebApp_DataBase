using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static bool DigitCheck(string str)
        {
            Console.WriteLine($"DigitCheck обрабатывает str=={str}!");
            for (int i = 0; i < str.Length; i++)
                if ((str[i] < 48) || (str[i] > 57))
                {
                    if ((str[i] == ',') && (((i + 1) == str.Length) || (i == 0)))
                    {
                        Console.WriteLine($"i={i}  ошибка 1 Введите число!");
                        return false;
                    }
                    if ((str[i] == '-') && (i != 0))
                    {
                        Console.WriteLine($"i={i} ошибка 2 Введите число!");
                        return false;
                    }
                    if ((str[i] != '-') && (str[i] != ','))
                    {
                        Console.WriteLine($"i={i} ошибка 2 Введите число!");
                        return false;
                    }
                }

            return true;
        }

        static string ReadNumFromLine(string str, out double a)
        {
            int i = 0, count = 0;
            string num = "";
            char[] res = new char[100];
            //Console.WriteLine(str);
            if ((str.Length == 0) || (str[0] == '\0'))
            {
                a = 0;
                return str;
            }
            else
            {
                while ((i != str.Length) && (str[i] != ' ') && (str[i] != '\t'))
                {
                    num = num + Convert.ToString(str[i]);
                    count++;
                    i++;
                }
                // while ((i < str.Length)&&(((str[i] < 48) || (str[i] > 57)) && (str[i] != 45) && (str[i] != '\0')))
                while ((i < str.Length) && ((str[i] == ' ') || (str[i] == '\t')))
                {
                    count++;
                    i++;
                }
                str = str.Substring(count);
                if (num.Length > 0)
                {
                    if (DigitCheck(num))
                        a = Convert.ToDouble(num);
                    else
                        a = 0;
                }
                else
                {
                    Console.WriteLine($"Ошибка при str={str}!" + $"res={res}!" + $"num={num}!");
                    a = 0;
                }
                return str;
            }
        }

        static void Main(string[] args)
        {
            int size = 1000;
            Random rnd = new Random();
            string str;
            int i = 0, count = 0;
            double[] dat = new double[size];
            double a;
            str = Console.ReadLine();
            while (str.Length > 0)
            {
                str = ReadNumFromLine(str, out a);
                dat[i] = a;
                i++;
            }
            count = i;
            for (i = 0; i < count; i++)
                Console.Write($"{dat[i]} ");
            Console.ReadKey();
        }
    }
}
