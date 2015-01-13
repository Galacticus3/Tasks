using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class SalesPerson : Employee
    {
        private int numberOfSales;
        public SalesPerson() { }
        public SalesPerson(string name, int age, int id, float pay, string ssn, int numbOfSales)
            : base(name, age, id, pay, ssn)
        {
            numberOfSales = numbOfSales;
        }
        
        public int SalesNumber
        {
            get { return numberOfSales; }
            set { numberOfSales = value; }
        }
    }
}
