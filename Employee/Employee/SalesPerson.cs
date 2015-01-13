using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class SalesPerson : Employee
    {
        //Поля данных
        private int numberOfSales;
        //Конструкторы
        public SalesPerson() { }
        public SalesPerson(string name, int age, int id, float pay, string ssn, int numbOfSales)
            : base(name, age, id, pay, ssn)
        {
            numberOfSales = numbOfSales;
        }
        //Методы доступа
        public int SalesNumber
        {
            get { return numberOfSales; }
            set { numberOfSales = value; }
        }
        //Члены
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (numberOfSales >= 0 && numberOfSales <= 100) { salesBonus = 10; }
            else if (numberOfSales >= 101 && numberOfSales <= 200) { salesBonus = 15; }
            else { salesBonus = 20; }
            base.GiveBonus(amount * salesBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Numbber of Sales: {0}", numberOfSales);
        }
    }
}
