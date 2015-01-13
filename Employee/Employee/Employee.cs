using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    abstract class Employee
    {
        // Поля данных
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        private static string companyName;
        private BenefitPackage empBenefits = new BenefitPackage(); // Содержит объект BenefitPackage
        public double GetBenefitCost() { return empBenefits.ComputePayDeduction(); } // поведение связанное с включенным объектом
        // Конструкторы
        public Employee() { }
        //static Employee() { companyName = "Intertech Training"; } // статический конструктор, с ним не надо в проге задавать значение для companyName
        public Employee (string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empAge = age;
            empID = id;
            empSSN = ssn;
            currPay = pay;
        }
        // В Employee вложен класс BenefitPackage2
        public class BenefitPackage2
        {
            // В BenefitPackage2 вложено перечисление (enum BenefitPackageLevel)
            public enum BenefitPackageLevel
            {
                Standart, Gold, Platinum
            }
            public double ComputePayDeduction2()
            {
                return 125.0;
            }
        }

        // Члены
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
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
            protected set { empSSN = value; }
        }
        public static string Company
        {
            get { return companyName; }
            set { companyName = value; }
        }
        // Представляет объект через специальное свойство
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
    }
}
