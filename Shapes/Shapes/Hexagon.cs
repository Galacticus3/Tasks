using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Hexagon : Shape
    {
        //Конструкторы
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        //Методы
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Drawing {0} is the Hexagon", shapeNmae);
        }


    }
}
