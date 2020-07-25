using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _14._1
{
    class Car: Vehicle
    {
       protected int Volume;
       protected int Consumption;

        public int volume
        {
            get
            {
                return Volume;
            }
            set
            {
                Volume = value;
            }
        }

        public int consumption
        {
            get
            {
                return Consumption;
            }
            set
            {
                Consumption = value;
            }
        }
        public Car(int volume, int consumption,string name,decimal powerful, decimal maxspeed,DateTime registrationdate,int cost):base(name, powerful, maxspeed, registrationdate,cost)
        {
            Volume = volume;
            Consumption = consumption;
        }

        double LostFuel(TimeSpan Duration)
        {
            return Duration.Hours * Consumption;
        }

        public int CountOfGasStation(TimeSpan Duration)
        {
            return Convert.ToInt32(Convert.ToString(LostFuel(Duration) / Volume));
        }

         public void Output()
        {
            base.Output();
            Console.WriteLine($"Емкость == {Volume}");
            Console.WriteLine($"Потребление == {Consumption}");
        }
    }
}
