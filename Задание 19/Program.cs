using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Code=1, Model="Huawei", Processor="AMD", Frequency="2.3",RAM=4,HHD=128,VideoCard=2,Cost=50000,Count=5},
                new Employee(){Code=2, Model="Acer", Processor="Intel", Frequency="3.5",RAM=8,HHD=512,VideoCard=6,Cost=70000,Count=4},
                new Employee(){Code=3, Model="Huawei", Processor="Intel", Frequency="4.0",RAM=16,HHD=1000,VideoCard=4,Cost=60000,Count=29},
                new Employee(){Code=4, Model="Xiaomi", Processor="AMD", Frequency="2.3",RAM=16,HHD=512,VideoCard=8,Cost=80000,Count=5},
                new Employee(){Code=5, Model="Asus", Processor="Intel", Frequency="3.5",RAM=4,HHD=128,VideoCard=2,Cost=90000,Count=12},
                new Employee(){Code=6, Model="Huawei", Processor="AMD", Frequency="2.3",RAM=8,HHD=1000,VideoCard=6,Cost=30000,Count=1},
            };

            Console.Write("Введите тип процессора: ");
            string processor = Console.ReadLine();
            List<Employee> employees1 = employees.Where(x => x.Processor == processor).ToList();
            Console.WriteLine("--Компьютеры с процессором {0}--", processor);
            Print(employees1);

            Console.Write("Введите требуемый объем оперативной памяти: ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Employee> employees2 = employees.Where(x => x.RAM >= ram).ToList();
            Console.WriteLine("--Компьютеры с ОЗУ 16 Гб и выше--");
            Console.WriteLine();
            Print(employees2);

            List<Employee> employees3 = employees.OrderBy(x => x.Cost).ToList();
            Console.WriteLine("Сортировка по возрастанию цены");
            Console.WriteLine();
            Print(employees3);

            List<Employee> employees4 = employees.OrderBy(x => x.Processor).ToList();
            Console.WriteLine("Сортировка по типу процессора");
            Console.WriteLine();
            Print(employees4);

            int min1 = employees.Min(n => n.Cost);
            Console.WriteLine("Самый дешёвый компьютер {0}", min1);
            int max1 = employees.Max(n => n.Cost);
            Console.WriteLine("Самый дорогой компьютер {0}", max1);
            Console.WriteLine();
            bool result1 = employees.Any(u => u.Count >= 30);
            if (result1)
                Console.WriteLine("На складе имеется компьютеры в наличии 30 штук и более");
            else
                Console.WriteLine("На складе нет компьютеров в наличие 30 штук и более");
            Console.ReadKey();
        }


        static void Print(List<Employee> employees)
        {
            Console.WriteLine("Код товара/Модель/Тип процессора/Частота/ОЗУ/HHD/Видеокарта/Цена/Наличие");
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Code} / {e.Model} / {e.Processor} / {e.Frequency} / {e.RAM} / {e.HHD} / {e.VideoCard} / {e.Cost} / {e.Count}");
            }
            Console.WriteLine();
        }
    }
    class Employee
    {
        public int Code { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string Frequency { get; set; }//частота работы процессора 
        public int RAM { get; set; }//объем оперативной памяти
        public int HHD { get; set; }// объем жесткого диска
        public int VideoCard { get; set; }//видеокарта
        public int Cost { get; set; }//стоимость
        public int Count { get; set; }//количество 
    }
}
