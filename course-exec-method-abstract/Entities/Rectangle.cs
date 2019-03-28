using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_exec_method_abstract.Entities.Enums;
namespace course_exec_method_abstract.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) :base(color)
        {
            Width = width;
            Height = height;

        }
        // Implementação da operação abstrata - Sobrescrita
        public override double Area()
        {
            return Width * Height;
        }
    }
}
