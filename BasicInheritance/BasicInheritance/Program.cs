﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Inheritance ****\n");
            Car myCar = new Car(80);
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} KM", myCar.Speed);
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My van is going {0} KM", myVan.Speed);
            //Ошибка! Нельза обращаться к приватным членам через ссылку на объект!
            //myVan.currSpeed = 51;
            Console.ReadLine();
        }
    }
}
