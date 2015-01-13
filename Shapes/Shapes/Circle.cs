using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        //Конструкторы
        public Circle() { }
        public Circle(string name) : base(name) { }
        
        //Методы
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} is the Circle", shapeNmae);
        }
    }
}
