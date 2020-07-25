using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
    class Program
    {


        static void input(out List<Car> Cars)
        {
            string str;
            List<Car> List=new List<Car>();
            Random rnd = new Random();
            Console.WriteLine("Для окончания заполнения введите '.' в поле названия автомобиля");
            Console.Write($"Введите название автомобиля: ");
            str = Console.ReadLine();
            while(str!=".")
            {

                List.Add(new Car(rnd.Next(), rnd.Next(),str, rnd.Next(), rnd.Next(), DateTime.Now, rnd.Next()));
                Console.Write($"Введите название автомобиля: ");
                str = Console.ReadLine();
            }
            Console.WriteLine($"Ввод автомобилей закончен");
            Cars = List;
        }

        static void input(out List<Vehicle> Vehicles)
        {
            string str;
            List<Vehicle> List = new List<Vehicle>();
            Random rnd = new Random();
            Console.WriteLine("Для окончания заполнения введите '.' в поле названия TC");
            Console.Write($"Введите название TC: ");
            str = Console.ReadLine();
            while (str != ".")
            {

                List.Add(new Vehicle(str, rnd.Next(), rnd.Next(), DateTime.Now, rnd.Next()));
                Console.Write($"Введите название TC: ");
                str = Console.ReadLine();
            }
            Console.WriteLine($"Ввод TC закончен");
            Vehicles = List;
        }

        static void output(List<Car> Cars)
        {
            Console.WriteLine("/////////////Вывод Машин");
            foreach (Car ptr in Cars)
                ptr.Output();
            Console.WriteLine("/////////////Вывод Машин окончен");
        }


        static void output(List<Vehicle> Cars)
        {
            Console.WriteLine("/////////////Вывод TC");
            foreach (Vehicle ptr in Cars)
                ptr.Output();
            Console.WriteLine("/////////////Вывод TC окончен");
        }

        static void Main(string[] args)
        {
            Cars List = new Cars();
            string str;
            input(out List.Auto);
            input(out List.Vehicles);
            List.Merger();
            List.SortBy("name");
            List.Output();
            Console.ReadKey();
            
        }
    }
}
