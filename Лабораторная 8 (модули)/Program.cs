using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8__модули_
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();
            Console.Write("Введите вариант: ");
            int variant = Convert.ToInt32(Console.ReadLine());
            Exam bilet = new Exam("Лебедева Серафима", new DateTime(2007, 01, 07));
            bilet.PrintMark();

            Console.ReadKey();
        }


      
  
        
    }
}
