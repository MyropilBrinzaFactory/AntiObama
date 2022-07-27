using System;

namespace ffk1x
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle(int intensity = 0, string name = "")
        {
            if(intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
