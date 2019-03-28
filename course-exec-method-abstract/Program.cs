using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using course_exec_method_abstract.Entities;
using course_exec_method_abstract.Entities.Enums;

namespace course_exec_method_abstract
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($" Shape #{i} data : ");
                Console.WriteLine("Rectangle or Circle (r/c) ? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
               

            }
        }
    }
}
