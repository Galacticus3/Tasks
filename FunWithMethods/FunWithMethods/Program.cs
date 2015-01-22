using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {


        public static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
        public static void Swapp(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with methods*****\n");
            int x = 8, y = 9;
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90+90={0}", ans);
            //-----------------
            string s1 = "aaa";
            string s2 = "bbb";
            Console.WriteLine("\nBefore: {0}  {1}", s1, s2);
            Swapp(ref s1,ref s2);
            Console.WriteLine("After: {0}  {1}", s1, s2);


            Console.ReadLine();
        }
    }
}
