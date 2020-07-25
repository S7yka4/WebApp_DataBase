using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
    class Cars
    {
        public List<Vehicle> Vehicles;
        public List<Car> Auto;

        public void Add(string name, decimal powerful, decimal maxspeed, DateTime regtime, int cost, int volume=-1000, int consumption=-1000)
        {
            if((volume==-1000)&&(consumption == volume-1000))
                Vehicles.Add(new Vehicle(name, powerful, maxspeed, regtime, cost));
            else
                Auto.Add(new Car(volume,consumption,name, powerful, maxspeed, regtime, cost));

        }

        public double ProfitOfGasStation(double CostOfFullTank)
        {
            double res=0;
            foreach(var ptr in Auto)
                res = res + CostOfFullTank;
            return res;
        }

        
        public void Merger()
        {
            foreach (var ptr in Vehicles)
                Auto.Add(new Car(0, 0, ptr.name, ptr.powerful, ptr.maxSpeed, ptr.registrationDate, ptr.cost));
        }

        private void change( int i, int j)
        {
            var dt = new DateTime();
            Car tmp = new Car(0, 0, "", 0, 0, dt, 0);
            tmp = Auto[i];
            Auto[i] = Auto[j];
            Auto[j] = tmp;
        }

        public void SortBy(string str)
        {
            var dt = new DateTime();
            Car tmp = new Car(0, 0, "", 0, 0, dt, 0);
            //Console.WriteLine($"\n\nstr=!{str}!\n");
            if(str=="name")
                for(int j=1;j<Auto.Count;j++)
                    for(int i=0;i<Auto.Count-1;i++)
                        if(String.Compare(Auto[i].name,Auto[i+1].name)>0)
                            change(i,i+1);
            if (str == "powerful")
                for (int j = 1; j < Auto.Count; j++)
                    for (int i = 0; i < Auto.Count - 1; i++)
                        if (Auto[i].powerful > Auto[i + 1].powerful)
                            change(i, i + 1);
            if (str == "maxspeed")
                for (int j = 1; j < Auto.Count; j++)
                    for (int i = 0; i < Auto.Count - 1; i++)
                        if (Auto[i].maxSpeed > Auto[i + 1].maxSpeed)
                            change(i, i + 1);
            if (str == "registrationdate")
                for (int j = 1; j < Auto.Count; j++)
                    for (int i = 0; i < Auto.Count - 1; i++)
                        if (Auto[i].registrationDate > Auto[i + 1].registrationDate)
                            change(i, i + 1);
            if (str == "cost")
                for (int j = 1; j < Auto.Count; j++)
                    for (int i = 0; i < Auto.Count - 1; i++)
                        if (Auto[i].cost > Auto[i + 1].cost)
                            change(i, i + 1);
            if (str == "volume")
                for (int j = 1; j < Auto.Count; j++)
                    for (int i = 0; i < Auto.Count - 1; i++)
                        if (Auto[i].volume > Auto[i + 1].volume)
                            change(i, i + 1);
            if (str == "consumption")
                for (int j = 1; j < Auto.Count; j++)
                    for (int i = 0; i < Auto.Count - 1; i++)
                        if (Auto[i].consumption > Auto[i + 1].consumption)
                            change(i, i + 1);
        }

        public void Output()
        {
            foreach (var ptr in Auto)
                ptr.Output();
        }
    }
}
