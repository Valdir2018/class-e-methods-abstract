using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_exec_method_abstract.Entities.Enums;

namespace course_exec_method_abstract.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

      

        public Shape(Color Color)
        {
            this.Color = Color;
        }

        public abstract double Area();
    }
}
