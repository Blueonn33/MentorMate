using System;

namespace Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете името си: ");
            string firstName = Console.ReadLine();
            Console.Write("Напишете презимето си: ");
            string secondName = Console.ReadLine();
            Console.Write("Напишете фамилията си: ");
            string lastName = Console.ReadLine();
            Console.Write("През коя година сте родени: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("През кой месец сте родени: ");
            int month =int.Parse(Console.ReadLine());
            Console.Write("На кой ден сте родени: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Името {0} съдържа {1} букви",firstName ,firstName.Length);
            Console.WriteLine("Името {0} съдържа {1} букви", secondName, secondName.Length);
            Console.WriteLine("Името {0} съдържа {1} букви", lastName, lastName.Length);
            string sumNames = firstName + secondName + lastName;
            Console.WriteLine("Трите ви имена съдържат {0} букви", sumNames.Length);
            Console.Write("Според името ви, вие сте: ");
            int number = sumNames.Length;
            string stringNumber = number.ToString();
            int newNumber = 0;

            foreach (char c in stringNumber)
            {
                newNumber = newNumber + int.Parse(c.ToString());
            }
            if(newNumber == 1) 
            {
                Console.WriteLine("художник");
            }
            else if (newNumber == 2)
            {
                Console.WriteLine("музикант");
            }
            else if (newNumber == 3)
            {
                Console.WriteLine("футболист");
            }
            else if (newNumber == 4)
            {
                Console.WriteLine("актьор");
            }
            else if (newNumber == 5)
            {
                Console.WriteLine("шахматист");
            }
            else if (newNumber == 6)
            {
                Console.WriteLine("поет");
            }
            else if (newNumber == 7)
            {
                Console.WriteLine("добър шофьор");
            }
            else if (newNumber == 8)
            {
                Console.WriteLine("плувец");
            }
            else if (newNumber == 9)
            {
                Console.WriteLine("хакер");
            }
            else if (newNumber == 10)
            {
                Console.WriteLine("танцьор");
            }
            int sum = year + month + day;
            Console.Write("Според датата, на която се родени, вие: ");

            if ( sum == 2020)
            {
                Console.WriteLine(" изпитвате страх от тъмното");
            }
            else if (sum == 2021)
            {
                Console.WriteLine("изпитвате страх от котки");
            }
            else if (sum == 2022)
            {
                Console.WriteLine("изпитвате страх от паяци");
            }
            else if (sum == 2023)
            {
                Console.WriteLine("обичате кучета");
            }
            else if (sum == 2024)
            {
                Console.WriteLine("обичате да рисувате");
            }
            else if (sum == 2025)
            {
                Console.WriteLine("обичате да пеете");
            }
            else if (sum == 2026)
            {
                Console.WriteLine("можете да свирите на китара");
            }
            else if (sum == 2027)
            {
                Console.WriteLine("можете да танцувате добре");
            }
            else if (sum == 2035)
            {
                Console.WriteLine("обичате да играете шах");
            }

        }
    }
}
