using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Encupsulation ****\n");
            Employee emp = new Employee("Marvin", 25, 456, 30000, "Number SSN");
            emp.GiveBonus(1000);
            emp.Age++;
            emp.DisplayStats();
            //Использовать метод get/set для взаимодействия с полем name объекта
            emp.SetName("Marvin1");
            Console.WriteLine("Employee is named: {0}", emp.GetName());
            // (2 способ) Установка и получений свойств Name
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.ReadLine();
        } 

    }
}
