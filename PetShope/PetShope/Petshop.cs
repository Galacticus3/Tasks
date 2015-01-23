using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShope
{
    class Petshop
    {
        public static void AddPet(Enimals p, List<Enimals> ListAll)
        {
            ListAll.Add(p);
        }

        public static void IntroduceAll(List<Enimals> ListAll)
        {
            foreach (Enimals p in ListAll)
            {
                p.Introduce();
            }
        }
    }
}
