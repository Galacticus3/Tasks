using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {

        static void SharedMembersOfObject()
        {
            // Статические члены System.Object
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine("p3 and p4 have same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("p3 and p4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with System.Object ****\n");
            Person a1 = new Person("Piter","Byork",32);
            
            //Использовать наследованные члены System.Object
            Console.WriteLine("To String: {0}", a1.ToString());
            Console.WriteLine("Hash code: {0}", a1.GetHashCode());
            Console.WriteLine("Type: {0}", a1.GetType());

            //Создать другую ссылку на р1
            Person a2 = a1;
            object o = a2;

            //Указывают ли ссылки на один и тот же объект в памати?
            if (o.Equals(a1) && o.Equals(a2))
            {
                Console.WriteLine("Same instance!");
            }
            Console.WriteLine("----------TESTS---------\n;");
            //p1 и р2 идентичны! Для проверки методо Equals() и GetHashCode()
            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);
            //Получить строковые версии объектов
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            //Проверить переопределённый метод Equals();
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
            //Проверить хеш-коды
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();
            //Изменить возраст р2 и проверить снова
            p2.personAge = 45;
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            SharedMembersOfObject();
            Console.ReadLine();

        }
    }
}
