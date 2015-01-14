using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        //Поля данных (public для простоты)
        public string fName;
        public string lName;
        public byte personAge;
        //Конструкторы
        public Person() { }
        public Person(string firstName, string lastName, byte age)
        {
            fName = firstName;
            lName = lastName;
            personAge = age;
        }
        //Члены
        public override string ToString()
        {
            string myState;
            myState = string.Format("[First name: {0}; Last name: {1}; Age: {2}]", fName, lName, personAge);
            //return base.ToString();
            return myState;
        }
        public override bool Equals(object obj)
        {
        /*  //(1 способ) Проверить или это тип Person, размещён ли памяти, а не пустая ссылка
             if (obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.fName == this.fName && temp.lName == this.lName && temp.personAge == this.personAge)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            //return base.Equals(obj);   */

            //Если у класс есть правильная реализация ToString(), которая учитывет 
            //все поля данных вверх по цепочке наследования, то можно другой способ;
            //больше нет необходимости приводить 'obj' к типу Person, по скольку у всех есть метод ToString()
            return obj.ToString() == this.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
            //return base.GetHashCode();
        }

    }
}
