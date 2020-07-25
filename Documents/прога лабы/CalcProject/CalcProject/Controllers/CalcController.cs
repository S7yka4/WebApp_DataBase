using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalcProject.Manager;
using CalcProject.Models;

namespace CalcProject.Controllers
{
    public class CalcController : Controller
    {
        private NumberSystem tmp;
        public CalcController(NumberSystem _tmp)
        {
            tmp = _tmp;
        }

        static bool DigitCheck(string str)
        {
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


        public ViewResult ProjectMenuPage()
        {
            return View();
        }

        public ViewResult CalcInputPage()
        {
            return View();
        }
        
        public ViewResult CalcOutputPage(string A, string B)
        {
            tmp.A = Convert.ToDouble(A);
            tmp.B = Convert.ToDouble(B);
            tmp.K=8;
            return View(tmp);
        }
    
        public ViewResult FirstQuestInput()
        {
            return View();
        }
    
        public ViewResult FirstQuestOutput(string InputStr)
        {
            double[] dat = new double[1000];
            double a;
            int i=0;
            while(InputStr.Length!=0)
            {
                InputStr = ReadNumFromLine(InputStr, out a);
                dat[i] = a;
                i++;
            }
            tmp.CountOfPositive(dat);
            return View(tmp.CountOfPositive(dat));
        }

    }
}