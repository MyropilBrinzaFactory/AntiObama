using System;

namespace ffk1x
{
    class Car
    {
        // Состояние объекта Car
        public string carName;
        public int carSpeed;

        // Специальный стандартный конструктор
        public Car()
        {
            carName = "Sonik";
            carSpeed = 15;

        }

        public Car(string pn) => carName = pn;

        // Позволяет вызывающему коду установить полное состояние объекта Car.
        public Car(string pn, int cs)
        {
            carName = pn;
            carSpeed = cs;
        }

        public void PrintState()
            => Console.WriteLine($"{carName} is goind {carSpeed} MPH.");

    }
}
