using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShope
{
    class Dog : Petshop
    {
        public Dog() { }
        public Dog(string name, string breed)
            : base(name, breed) { }

        public override void Introduce()
        {
            base.Introduce();
            Console.Write(" I am a dog");
        }
    }
}
