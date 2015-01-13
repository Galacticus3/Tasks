using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        // Поля данных
        public readonly int maxSpeed;
        private int currSpeed;
        // Конструкторы
        public Car() { maxSpeed = 55; }
        public Car(int max) { maxSpeed = max; }
        // Методы доступа
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed += value;
                if (currSpeed > maxSpeed) { currSpeed = maxSpeed; }
            }
        }
    }
}
