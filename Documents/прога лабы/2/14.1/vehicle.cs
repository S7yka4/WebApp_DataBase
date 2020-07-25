using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
    class Vehicle
    {
        protected string Name;
        protected decimal Powerful;
        protected decimal MaxSpeed;
        protected DateTime RegistrationDate;
        protected int Cost;
        protected int HorsePower;

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public decimal powerful
        {
            get
            {
                return Powerful;
            }
            set
            {
                Powerful = value;
            }
        }
        public decimal maxSpeed
        {
            get
            {
                return MaxSpeed;
            }
            set
            {
                MaxSpeed = value;
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
        public int cost
        {
            get
            {
                return Cost;

            }
            set
            {
                Cost = value;
            }
        }
        public int horsePower
        {
            get
            {
                return HorsePower;
            }
            set
            {
                HorsePower = value;
            }
        }

        public Vehicle(string name, decimal powerful, decimal maxspeed, DateTime regtime, int cost)
        {
            Name = name;
            Powerful = powerful;
            MaxSpeed = maxspeed;
            RegistrationDate = regtime;
            Cost = cost;
            HorsePower = Convert.ToInt32(Powerful/735499)*1000;

        }

        public double LengthOfWay(TimeSpan Duration)
        {
            return Convert.ToDouble((MaxSpeed / 2) * (Duration.Hours + Duration.Minutes / 60 + Duration.Seconds / 3600));
        }

        public  double Tax(DateTime Date, double Rate)
        {
            double Coefficient=1;
            int tmp=Date.Year,i;
            if (Cost > 3000000)
                tmp--;
            if ((Date.Year - RegistrationDate.Year) > 1)
                Coefficient = Coefficient + 0.05 * (Date.Month - RegistrationDate.Month);
            return (Rate * HorsePower*(RegistrationDate.Month-Date.Month)*Coefficient);
        }

        public virtual void Output()
        {
            Console.WriteLine($"\nНазвание == {Name}");
            Console.WriteLine($"Мощность == {Powerful}");
            Console.WriteLine($"Максимальная скорость == {MaxSpeed}");
            Console.WriteLine($"Дата регистрации == {RegistrationDate}");
            Console.WriteLine($"Стоимость == {Cost}");
            Console.WriteLine($"Мощность в лошадиных силах == {HorsePower}");
        }
    }
}
