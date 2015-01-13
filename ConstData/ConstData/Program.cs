using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with const ****\n");
            Console.WriteLine("PI = {0};", MyMathClass.PI); 
            // ОШИБКА!!! Нельзя изменять константу!
            // MyMathClass.PI = 3.1444;
            MyMathClass m = new MyMathClass();
            
            Console.ReadLine();
        }
    }
}
