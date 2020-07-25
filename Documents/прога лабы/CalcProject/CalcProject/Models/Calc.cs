using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcProject.Manager;

namespace CalcProject.Models
{
    public class Calc: NumberSystem
    {
        protected double a;
        protected double b;
        public int K { get; set; }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public double Summ()
        {
            return a + b;
        }

        public double Subtraction()
        {
            return a - b;
        }

        public double Segmentation()
        {
            return a / b;
        }

        public double Multiplication()
        {
            return a * b;
        }

        public double Pow()
        {
            double tmp=a;
            double Deg=b;
            while(Deg>0)
            {
                tmp = tmp * a;
                Deg = Deg - 1;
            }
            return tmp;
        }

        public double Div()
           {
               double tmp = a;
               int res = 0;
               while(tmp>=b)
               {
                   res++;
                   tmp = tmp - b;
               }
               return res;
           }

        public double Mod()
        {
            return a-Div()*b;
        }


        public int CountOfPositive(double[] dat)
        {
            int res=0;
            for (int i = 0; i < dat.Length; i++)
                if (dat[i] > 0)
                    res++;
            return res;
        }
    }
}
