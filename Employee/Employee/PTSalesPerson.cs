﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson() { }
        public PTSalesPerson(string name, int age, int id, float pay, string ssn, int numbOfSales)
            : base(name, age, id, pay, ssn, numbOfSales)
        {

        }
        // Остальные члены ...
    }
}
