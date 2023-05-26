using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            string a = "hello";
            string b = "world";
            Console.WriteLine(a + " " + b);
            Console.WriteLine();

            Console.WriteLine("№2");
            int c = 18;
            int d = 6;
            Console.WriteLine(c + d);
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);
            Console.WriteLine();

            Console.WriteLine("№3");
            Console.Write("Введите Имя: ");
            string e = Console.ReadLine();
            Console.Write("Введите Фамилию: ");
            string f = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string g = Console.ReadLine();
            Console.WriteLine(e + " " + f + " " + g);
            Console.WriteLine();

            Console.WriteLine("№4");
            int hpP = 100;
            int dmgP = 25;
            int defP = 10;

            int hpM = 150;
            int dmgM = 15;
            int defM = 5;

            int dmgDealM = dmgM - defP;
            int dmgDealP = dmgP - defM;

            int hpRemainP = hpP - dmgDealM;
            int hpRemainM = hpM - dmgDealP;

            Console.WriteLine("HP Player - " + hpRemainP);
            Console.WriteLine("HP Monster - " + hpRemainM);
            Console.WriteLine("Damage deal from player - " + dmgDealP);
            Console.WriteLine("Damage deal from monster - " + dmgDealM);
        }
    }
}
