using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShope
{
    class Petshop
    {
        private string Name;
        private string Breed;

        public Petshop() { }
        public Petshop(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public virtual void Introduce()
        {
            Console.WriteLine("\nI am {0} of {1}",Name,Breed);
        }

        public virtual void AddPet(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        
        public void IntroduceAll()
        {
         
        }
        
        public string petName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string petBreed
        {
            get { return Breed; }
            set { Breed = value; }
        }
    }
}
