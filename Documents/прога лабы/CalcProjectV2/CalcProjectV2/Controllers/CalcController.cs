using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalcProjectV2.Models;
using CalcProjectV2.Manager;

namespace CalcProjectV2.Controllers
{
    public class CalcController : Controller
    {
       public static NumberSystem _tmp=new CalcFor8();
        public static double res;
        public IActionResult ProjectMenuPage()
        {
            return View();
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

        public IActionResult CalcOutputPage()
         {
             return View(_tmp);
         }


        public IActionResult CalcInputPage()
        {
            return View();
        }

        public IActionResult NextPage()
        {
            return View(_tmp);
        }
        [HttpPost]
        public IActionResult Calculation(string Action,string B)
        {
            _tmp.B = Convert.ToDouble(B);
            if (Action == "+")
            {
                _tmp.Result = _tmp.Summ();
                return RedirectToAction(nameof(NextPage));
            }
            if (Action == "-")
            {
                _tmp.Result = _tmp.Subtraction();
                return RedirectToAction(nameof(NextPage));
            }
            if (Action == "*")
            {
                _tmp.Result = _tmp.Multiplication();
                return RedirectToAction(nameof(NextPage));
            }
            if (Action == "/")
            {
                _tmp.Result = _tmp.Segmentation();
                return RedirectToAction(nameof(NextPage));
            }
            if (Action == "^")
            {
                _tmp.Result = _tmp.Pow();
                return RedirectToAction(nameof(NextPage));
            }
            if (Action == "Div")
            {
                _tmp.Result = _tmp.Div();
                return RedirectToAction(nameof(NextPage));
            }
            if (Action == "Mod")
            {
                _tmp.Result = _tmp.Mod();
                return RedirectToAction(nameof(NextPage));
            }
            return RedirectToAction(nameof(ErrorPage));
        }
        
        
        public /*void*/IActionResult CalcProcess(string A,string B, string K="10",string Action="0")
        {
            try
            {
                _tmp.Result = Convert.ToDouble(A);
                _tmp.K = Convert.ToInt32(K);
                //Calculation(Action,B);
                _tmp.B = Convert.ToDouble(B);
                if (Action == "+")
                {
                    _tmp.Result = _tmp.Summ();
                    return RedirectToAction(nameof(NextPage));
                }
                if (Action == "-")
                {
                    _tmp.Result = _tmp.Subtraction();
                    return RedirectToAction(nameof(NextPage));
                }
                if (Action == "*")
                {
                    _tmp.Result = _tmp.Multiplication();
                    return RedirectToAction(nameof(NextPage));
                }
                if (Action == "/")
                {
                    _tmp.Result = _tmp.Segmentation();
                    if (_tmp.B != 0)
                        return RedirectToAction(nameof(NextPage));
                    else
                        return RedirectToAction(nameof(ErrorPage));
                }
                if (Action == "^")
                {
                    _tmp.Result = _tmp.Pow();
                    return RedirectToAction(nameof(NextPage));
                }
                if (Action == "Div")
                {
                    _tmp.Result = _tmp.Div();
                    return RedirectToAction(nameof(NextPage));
                }
                if (Action == "Mod")
                {
                    _tmp.Result = _tmp.Mod();
                    return RedirectToAction(nameof(NextPage));
                }
            }
            catch
            {
                return RedirectToAction(nameof(ErrorPage));
            }
            return RedirectToAction(nameof(ErrorPage));
        }


        public IActionResult ErrorPage()
        {

            return View();
        }

        public IActionResult FirstQuestInput()
        {
            return View();
        }

        public IActionResult FirstQuestOutput(string InputStr)
        {
            double[] dat = new double[1000];
            double a;
            int i = 0;
            while (InputStr.Length != 0)
            {
                InputStr = ReadNumFromLine(InputStr, out a);
                dat[i] = a;
                i++;
            }
            return View(_tmp.MinOfArray(dat,i));
        }
    }
}