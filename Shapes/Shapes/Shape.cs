using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        //Поля данных
        protected string shapeNmae;

        //Конструкторы
        public Shape()
        {
            shapeNmae = "NoName";
        }
        public Shape(string s)
        {
            shapeNmae = s;
        }

        //Методы

        public abstract void Draw();
        //{ Console.WriteLine("Inside Shape.Draw()");}
       
        public string PetName
        {
            get { return shapeNmae; }
            set { shapeNmae = value; }
        }
    }
}
