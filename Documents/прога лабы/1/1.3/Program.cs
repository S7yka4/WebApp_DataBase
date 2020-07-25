using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3. Создать список «Успеваемость студента П.  из  СТАНКИНа»  (Предмет,  Оценка  за экзамен/Зачет).
 * Вывести  на  экран  те элементы  списка,
 * которые  соответствуют отметке «Хорошо».*/


namespace _1._3
{
    class Program
    {
        class progress
        {
            string subject;
           public int mark;

            public progress(string str, int i)
            {
                subject = str;
                mark = i;
            }

            public void output()
            {
                Console.WriteLine();
                Console.WriteLine($"Название предмета: {subject}");
                Console.WriteLine($"Оценка за зачет/экзамен: {mark}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            List<progress> P = new List<progress>();
            int m;
            string str;
            Console.WriteLine("Для окончания заполнения введите '.' в поле назания предмета");
            Console.Write("Название предмета: ");
            str = Console.ReadLine();
            while(str!=".")
            {
                Console.Write("Оценка: ");
                m = Convert.ToInt32(Console.ReadLine());
                P.Add(new progress(str,m));
                Console.Write("Название предмета: ");
                str = Console.ReadLine();
            }
                foreach (progress ptr in P.Where(ptr => ptr.mark==4))
                    ptr.output();
            Console.ReadLine();
        }
    }
}
