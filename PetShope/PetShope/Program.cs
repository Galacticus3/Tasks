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
            /* Create next classes: Cat, Dog and Petshop.
            Types Cat and Dog have fields Name and Breed and method Introduce() which prints text “I’m (Name) of (Breed). I’m a cat (or dog)”.
            The class Petshop collects in its container different pets.
            We may add new pet to container by method AddPet() and we may display information about all pets by method IntroduceAll().
            Which hierarchy of classes is the best solution of this problem?
            Write short code to demonstrate your solution. Your code should include class (interface) aggregation, inheritance, 
            should use .NET BCL collections or generics, should implement exception handling*/
            Console.WriteLine("**** Fun with pets ****\n");
            List<Enimals> Pets = new List<Enimals>();
           
            Cat cat1 = new Cat();
            cat1.petBreed = "housecat";
            cat1.petName = "Vasya";
            //Pets.Add(cat1);
            Petshop.AddPet(cat1, Pets);
            cat1.Introduce();

            Cat cat2 = new Cat("Kolya","streetcat");
            Petshop.AddPet(cat2, Pets);
            cat2.Introduce();

            Dog dog1 = new Dog("Sharik", "streetdog");
            //Pets.Add(new Dog("SHarik", "streetdog")); // тоже классный способ добавить в List<>
            Petshop.AddPet(dog1, Pets);

            Console.WriteLine("\n------------All pets in petshop-------------");
            //foreach (Petshop p in Pets) { p.Introduce(); }
            Petshop.IntroduceAll(Pets);

            Console.ReadLine();
        }
    }
}
