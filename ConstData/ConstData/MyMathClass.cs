using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public static readonly double PI;

        static MyMathClass() 
        {
            PI = 3.14;
        }

        static void LocalConstStringValue()
        {
            const string fixedStr = "Fixed string data";
            Console.WriteLine(fixedStr);
            // Ошибка!!!
            // fixedStr = "Not work!";
        }
    }
}
