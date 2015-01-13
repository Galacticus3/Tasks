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
            Employee.Company = "Intertech Training";  // set для статической переменной
            Console.WriteLine("These folks work at {0}", Employee.Company); //get статической переменной
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
            SalesPerson danny = new SalesPerson();
            danny.Name = "Danny";
            danny.Age = 31;
            danny.SalesNumber = 50;
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-333", 9000);
            double cost = chucky.GetBenefitCost();
            //Определить мой уровень льгот с использованием вложенного класса BenefitPackage2 в родительский класс Employee
            Employee.BenefitPackage2.BenefitPackageLevel myBenefitLebel = Employee.BenefitPackage2.BenefitPackageLevel.Platinum;
            Console.ReadLine();
        } 

    }
}
