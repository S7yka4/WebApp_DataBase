using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VipAcc : BanckAcc
    {
        protected decimal AddedMoney;
        protected decimal ExtraBonus;

        public decimal addedMoney
        {
            get
            {
                return AddedMoney;
            }
            set
            {
                AddedMoney = value;
            }
        }
        public decimal extraBonus
        {
            get
            {
                return ExtraBonus;
            }
            set
            {
                ExtraBonus = value;
            }
        }

        public VipAcc(int id, decimal amount, decimal interestRate, DateTime registrationDate, decimal addedMoney) : base(id, amount, interestRate, registrationDate)
        {
            AddedMoney = addedMoney;
            ExtraBonus = Convert.ToInt32(Math.Round(addedMoney / 10000)) * Convert.ToDecimal(0.1);
        }

        public decimal EstimatedAmount(decimal refill, DateTime Date)
        {
            int i, j;
            DateTime dt = new DateTime();
            decimal res = 0;
            Console.WriteLine($"\n\nAmount=={Amount} Refill=={refill}");
            for (i = 0; i < (Date.Year - DateTime.Now.Year); i++)
                for (j = 1; j <= 12; j++)
                {
                    dt = DateTime.Now;
               
                    dt=dt.AddYears(i);
               
                    dt=dt.AddMonths(j);
                    
                    res = res + refill;
                
                    Console.WriteLine($"{Id} {Amount} {dt} {i * 12 + j} {Amount + res}");
                }
            for (j = 1; j <= (Date.Month - DateTime.Now.Year); j++)
            {
                dt = DateTime.Now;
               dt= dt.AddYears(i);
                dt=dt.AddMonths(j);
                res = res + refill;
               // Console.WriteLine($"{Id} {Amount} {dt} {i * 12 + j} {Amount + res}");
            }
            Console.WriteLine("\n");
            return res;
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine($"Средства, добавляющиеся ко счету каждый месяц — {AddedMoney}");
            Console.WriteLine($"Дополнительный бонус — {ExtraBonus}\n");
        }
    }
}
