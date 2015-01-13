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

       //   Можно было то того как базовый класс Employee стал абстрактным
       //   Employee emp = new Employee("Marvin", 25, 456, 30000, "111-11-111");    
       //   emp.GiveBonus(1000);
       //   emp.Age++;
       //   emp.DisplayStats();
            //Использовать метод get/set для взаимодействия с полем name объекта
       //   emp.SetName("Marvin1");
       //   Console.WriteLine("Employee is named: {0}", emp.GetName());
            // (2 способ) Установка и получений свойств Name
       //   emp.Name = "Marv";
       //   Console.WriteLine("Employee is named: {0}", emp.Name);

            //Дать каждому сотруднику бонус?
            SalesPerson danny = new SalesPerson();
            danny.Name = "Danny";
            danny.Age = 31;
            danny.SalesNumber = 50;
            danny.DisplayStats();
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-333", 9000);
            double cost = chucky.GetBenefitCost(); // поведение связанное с включенным объектом       
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-55-239", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            //Определить мой уровень льгот с использованием вложенного класса BenefitPackage2 в родительский класс Employee
            Employee.BenefitPackage2.BenefitPackageLevel myBenefitLebel = Employee.BenefitPackage2.BenefitPackageLevel.Platinum;
            Console.WriteLine("Status: {0}", myBenefitLebel);

            Console.ReadLine();
        } 

    }
}
