using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace task2
{
    public enum EducationType { 
        serednya = 0, 
        bakalawr = 1, 
        vyshcha = 2 
    };

    public enum ProfessionType { buhgalter, programist, sesurity, ekonomist, yurist, admin, krutan, kasyr };
    
    public class Person
    {
        public string name, surname, profession, day, money;
        public DateTime dob;
        public EducationType education;
        //public ProfessionType professions;
        public double zp;

        public Person(string nm, string snm, DateTime dob, EducationType education, string profession, double zp)
        {
            this.name = nm;
            this.surname = snm;
            this.dob = dob;
            this.education = education;
            this.profession = profession;
            this.zp = zp;
             
        }

        public Person()
        {
            name = "";
            surname = "";
            dob = DateTime.Parse("27.01.1985");
            //day = "";
            education = EducationType.bakalawr;
            profession = "";
            zp = 0;

        }
    }
}