﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Polymorphism ****\n");
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
            Circle cir = new Circle("Cindy");
            cir.Draw();
            Console.WriteLine("-----------------------------------");
            //Создать массив совместимых с Shape объектов
            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda")};
            //Пройти цикл по каждому элементу и взаимодействовать с полиморфным интерфейсом
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
             
            Console.ReadLine();
        }
    }
}
