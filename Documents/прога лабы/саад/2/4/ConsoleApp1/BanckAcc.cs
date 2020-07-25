using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BanckAcc
    {
        protected int Id;
        protected decimal Amount;
        protected decimal InterestRate;
        protected decimal Bonus;
        protected DateTime RegistrationDate;

        public  int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public decimal amount
        {
            get
            {
                return Amount;
            }
            set
            {
                Amount = value;
            }
        }
        public decimal interestRate
        {
            get
            {
                return InterestRate;
            }
            set
            {
                InterestRate = value;
            }
        }
        public decimal bonus
        {
            get
            {
                return Bonus;
            }
            set
            {
                Bonus = value;
            }
        }
        public DateTime registrationDate
        {
            get
            {
                return RegistrationDate;
            }
            set
            {
                RegistrationDate = value;
            }
        }


        private decimal CalculationOfBonus(DateTime Date)
        {
            int tmp = Date.Year;
            decimal res=0;
            while (tmp != RegistrationDate.Year)
            {
                res = res + Convert.ToDecimal(0.1);
                tmp--;
            }
            return res;
        }
        public BanckAcc(int id, decimal amount, decimal interestRate, DateTime registrationDate)
        {
            int tmp = DateTime.Now.Year;
            Id = id;
            Amount = amount;
            InterestRate = interestRate;
            RegistrationDate = registrationDate;
            Bonus = CalculationOfBonus(DateTime.Now);
        }
        public decimal Computation(DateTime PlanDate)
        {
            decimal amount=Amount;
            decimal bonus;
            bonus = CalculationOfBonus(PlanDate);
            for(int i=0;i< Convert.ToInt32(Bonus * 10);i++)
                amount=amount+Convert.ToDecimal(0.1) * amount;
            return amount;
        }

        public void Output()
        {
            Console.WriteLine($"\nИдентификационный номер -- {Id} ");
            Console.WriteLine($"Сумма -- {Amount}");
            Console.WriteLine($"Возвращаемая  доля  (%)  от  остатка  в  конце месяца -- {InterestRate}");
            Console.WriteLine($"Дополнительные проценты -- {Bonus}");
            Console.WriteLine($"Дата регистрации -- {RegistrationDate}\n");
        }

    }
}
