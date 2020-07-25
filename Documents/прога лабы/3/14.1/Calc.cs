using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
    class Calc: NumberSystem
    {
        protected double a;
        protected double b;
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
            while(b>0)
            {
                tmp = tmp * a;
                b = b - 1;
            }
            return tmp;
        }

        public int Div()
        {
            double tmp = b;
            int res = 0;
            while(tmp>=a)
            {
                res++;
                tmp = tmp - a;
            }
            return res;
        }
        public int Mod()
        {
            return Convert.ToInt32(Math.Round(b))- Div();
        }

        public int Comprasion()
        {
            if (a > b)
                return 1;
            else
                if (a < b)
                    return -1;
                else
                    if (a == b)
                        return 0;
            return 5;
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
