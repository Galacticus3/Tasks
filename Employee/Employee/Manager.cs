using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Manager : Employee
    {
        private int numberOfOptions;
        public Manager() { }
        public Manager(string name, int age, int id, float pay, string ssn, int numbOfOpts)
            : base(name, age, id, pay, ssn)
        {
            numberOfOptions = numbOfOpts;
        }
        
        public int StockOptions
        {
            get { return numberOfOptions; }
            set { numberOfOptions = value; }
        }
    }
}
