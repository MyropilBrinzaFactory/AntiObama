using System;
using System.Threading;

namespace ffk1x
{
    class ArendaTurismo
    {
        public string userName;
        public int userBalance;
        public double userTime;

        public ArendaTurismo() => Menu();

        public ArendaTurismo(string name)
            : this(name, 0, 0) { }

        public ArendaTurismo(string name, int balance)
            : this(name, balance, 0) { }

        public ArendaTurismo(int balance)
            : this("User", balance, 0) { }

        public ArendaTurismo(string name, int balance, double time)
        {
            userName = name;
            userBalance = balance;
            userTime = time;

            Buy();
        }

        public void Menu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Пополнение баланса");
            Console.WriteLine("3. Просмотр баланса");
            Console.WriteLine("4. Покупка часов");
            string select = Console.ReadLine();

            switch(select)
            {
                case "1":
                    Register();
                    break;
                case "2":
                    break;
                case "3":
                    CheckProfile();
                    break;
                case "4":
                    Buy();
                    break;
            }
        }

        public void Register()
        {
            Console.WriteLine("Ник:");
            userName = Console.ReadLine();
            Console.WriteLine("Баланс:");
            userBalance = int.Parse(Console.ReadLine());

            Thread.Sleep(2500);
            Console.Clear();

            Menu();
        }

        public void CheckProfile()
        {
            Console.WriteLine($"Ваш баланс: {userBalance}");
            Console.WriteLine($"Количество часов: {userTime}\n");

            Thread.Sleep(2500);
            Console.Clear();

            Menu();

        }

        public void Buy()
        {
            if (userBalance > 10)
            {
                string select = null;
                int hour = userBalance / 10;
                Console.WriteLine($"На вашем счету достаточно средств для покупки {hour} часов\n");
                Console.WriteLine("Купить часы каршеринга на все деньги? [Да/Нет]");
                select = Console.ReadLine();

                if (select == "Да")
                {
                    userBalance = 0;
                    Console.WriteLine($"{userName}, Вы купили {hour} часов");
                    userTime = hour;
                }
                if (select == "Нет")
                {
                    Console.WriteLine("Введите количество часов которые хотите купить:");
                    select = Console.ReadLine();
                    int buy = int.Parse(select);

                    while (buy > hour)
                    {
                        Console.WriteLine($"У вас недостаточно баланса для покупки {buy} часов");
                        Console.WriteLine("Повторите попытку покупки времени");
                        select = Console.ReadLine();
                        buy = int.Parse(select);
                    }

                    Console.WriteLine($"{userName}, Вы успешно купили {buy} часов\n");
                    userBalance = userBalance - (userBalance / 10);
                    userTime = buy;

                    CheckProfile();
                }
            }
            else
            {
                Console.WriteLine("На вашем счету нету денег для покупки даже 1-го часа\n");
            }

            Thread.Sleep(2500);
            Console.Clear();

            Menu();
        }
    }
}
