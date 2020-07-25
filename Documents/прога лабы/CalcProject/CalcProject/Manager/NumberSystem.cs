using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.Manager
{
   public interface NumberSystem
    {
        double A { get; set; }
        double B { get; set; }
        int K { get; set; }
        double Summ();
        double Subtraction();
        double Segmentation();
        double Multiplication();
        double Pow();
        // int Mod();
        //int Div();

        double Mod();
        double Div();
        int CountOfPositive(double[] dat);

    }
}
