using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffk1x
{
    // Простой класс депозитного счета
    class SavingsAccount
    {
        // Данные уровня экземпляра.
        public double currBalance;

        // Статический элемент данных.
        public static double currInterestRate;
        
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // Статический конструктор
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!"); // в статическом конструкторе
            currInterestRate = 0.04;
        }

        // Статические члены для установки/получения процентной ставки.
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetInterestRate()
        { return currInterestRate; }
    }
}
