using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Manager : Employee
    {
        //Поля данных
        private int numberOfOptions;
        //Конструкторы
        public Manager() { }
        public Manager(string name, int age, int id, float pay, string ssn, int numbOfOpts)
            : base(name, age, id, pay, ssn)
        {
            numberOfOptions = numbOfOpts;
        }
        //Методы доступа
        public int StockOptions
        {
            get { return numberOfOptions; }
            set { numberOfOptions = value; }
        }
        //Члены
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            numberOfOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", numberOfOptions);
        }
    }
}
