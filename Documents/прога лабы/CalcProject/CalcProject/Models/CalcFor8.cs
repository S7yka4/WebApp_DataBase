using System;
using System.Linq;
using CalcProject.Manager;

namespace CalcProject.Models {
	public class CalcFor8 : NumberSystem {
		public double A { get; set; }

		public double B { get; set; }

		public int K { get; set; }

		public double Summ() { return TranslateTo8(TranslateTo10(A) + TranslateTo10(B)); }

		public double Subtraction() { return TranslateTo8(TranslateTo10(A) - TranslateTo10(B)); }

		public double Multiplication() { return TranslateTo8(TranslateTo10(A) * TranslateTo10(B)); }

		public double Segmentation() { return TranslateTo8(TranslateTo10(A) / TranslateTo10(B)); }

		public double Pow() {
			var tmp = TranslateTo10(A);
			var Deg = TranslateTo10(B);
			while (Deg > 1) {
				tmp *= TranslateTo10(A);
				Deg -= 1;
			}

			return TranslateTo8(tmp);
		}

		public double Div() {
			var tmp = TranslateTo10(A);
			var res = 0;
			while (tmp >= TranslateTo10(B)) {
				tmp = tmp - TranslateTo10(B);
				res++;
			}

			return TranslateTo8(res);
		}

		public double Mod() { return TranslateTo8(TranslateTo10(A) - Div() * TranslateTo10(B)); }

		public int CountOfPositive(double[] dat) {
			var res = dat.Count(t => TranslateTo10(t) > 0);

			return Convert.ToInt32(TranslateTo8(res));
		}

		private double TranslateTo10(double a) {
			//поменять b на нужную систему счисления
			double res = 0;
			int B1;
			var flag = 1;
			var A1 = K;
			if (Convert.ToString(a).IndexOf(',') != -1) {
				for (var i = Convert.ToString(a).IndexOf(',') - 1; i >= 0; i--)
					if ((Convert.ToString(a)[0] == '-') && (i == 0))
						flag = 0;
					else {
						B1 = Convert.ToString(a).IndexOf(',') - (i + 1);
						res += (Convert.ToString(a)[i] - 48) * Math.Pow(A1, B1);
					}

				for (var i = Convert.ToString(a).IndexOf(',') + 1; i < Convert.ToString(a).Length; i++) {
					B1 = -1 * (i - Convert.ToString(a).IndexOf(','));
					res += (Convert.ToString(a)[i] - 48) * Math.Pow(A1, B1);
				}
			} else
				for (var i = Convert.ToString(a).Length - 1; i >= 0; i--) {
					if ((Convert.ToString(a)[0] == '-') && (i == 0))
						flag = 0;
					else {
						B1 = Convert.ToString(a).Length - (i + 1);
						res += (Convert.ToString(a)[i] - 48) * Math.Pow(A1, B1);
					}
				}

			if (flag == 0) return (-1) * res;
			return res;
		}

		static double FractPartOfNum(double a) { return a - Math.Truncate(a); }


		private double TranslateTo8(double a) //поменять B на нужную систему исчисления
		{
			string res = "";
			int A1, B1 = K;
			double tmp;
			if (Convert.ToString(a).IndexOf(',') != -1) {
				A1 = Convert.ToInt32(Math.Truncate(a)); //целая часть числа
				if (A1 < 0) A1 = A1 * (-1);
				while (A1 > 0) {
					res = Convert.ToString(A1 % B1) + res;
					Console.WriteLine(res);
					A1 = A1 / B1;
				}

				res = res + ',';
				tmp = FractPartOfNum(a); //дробная часть числа
				var i = 0;
				while ((FractPartOfNum(tmp) != 0) && (i != 5)) {
					res = res + Convert.ToString(Math.Truncate(tmp * B1));
					Console.WriteLine(res);
					tmp = FractPartOfNum(tmp * B1);
					i++;
				}
			} else {
				A1 = Convert.ToInt32(Math.Truncate(a));
				if (A1 < 0) A1 *= (-1);
				while (A1 > 0) {
					res = Convert.ToString(A1 % B1) + res;
					Console.WriteLine(res);
					A1 /= B1;
				}

				if (res.Length == 0) res = res + "0";
			}

			if (!(a < 0)) return Convert.ToDouble(res);
			res = ("-" + res);
			return Convert.ToDouble(res);
		}
	}
}