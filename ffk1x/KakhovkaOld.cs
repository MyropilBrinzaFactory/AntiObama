using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffk1x
{
    class KakhovkaOld
    {
        public string name;
        public int age;

        public static int ageOfOld;

        public KakhovkaOld(int age)
            : this("", age) { }

        public KakhovkaOld(string name)
            : this(name, 0) { }

        // Главный конструктор
        public KakhovkaOld(string userName, int userAge)
        {
            age = userAge;
            name = userName;
        }

        static KakhovkaOld()
        {
            ageOfOld = 65;
        }

        public void CheckOldKakhovka()
        {
            if(age >= 65)
                Console.WriteLine($"{name}, ты олдяра");
            else
                Console.WriteLine($"{name} откисай нубяра");
        }
    }
}
