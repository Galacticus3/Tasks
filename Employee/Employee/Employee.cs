using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        // Поля данных
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        // Конструкторы
        public Employee() { }
        public Employee (string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empAge = age;
            empID = id;
            empSSN = ssn;
            currPay = pay;
        }
        // Члены
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("SSN: {0}", empSSN);
            Console.WriteLine("Pay: {0}", currPay);
        }
        // Метод доступа (метод get)
        public string GetName()
        {
            return empName;
        }
                // Метод изменения (метод set)
        public void SetName(string name)
        {
            // Проверить все недопустимые символы, длину и регистр перед выполнением
            empName = name;
        }
        // Свойства
        public string Name
        {
            get { return empName; }
            set { empName = value; }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string SocialSecurityNumber
        {
            get { return empSSN; }
            set { empSSN = value; }
        }
    }
}
