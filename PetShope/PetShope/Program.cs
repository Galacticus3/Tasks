using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with pets ****\n");
           
            Cat cat1 = new Cat();
            cat1.petBreed = "housecat";
            cat1.petName = "Vasya";
            cat1.Introduce();

            Cat cat2 = new Cat("Kolya","streetcat");
            cat2.Introduce();

            Dog dog1 = new Dog("Sharik", "streetdog");
            dog1.Introduce();

            Console.ReadLine();
        }
    }
}
