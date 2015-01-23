using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShope
{
    class Petshop
    {
        List<Enimals> Pets;
        public Petshop()
        {
            List<Enimals> Pets = new List<Enimals>();
        }
        public void AddPet(Enimals p)
        {
            Pets.Add(p);
            //ListAll.Add(p);
        }

        public void IntroduceAll()
        {
            foreach (Enimals p in Pets)
            {
                p.Introduce();
            }
        }
    }
}
