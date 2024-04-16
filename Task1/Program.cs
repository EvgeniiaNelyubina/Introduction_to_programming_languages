// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;

class Program
{
    static bool СheckMultiplicity ()
    {
        Console.WriteLine ("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 7 == 0 && num % 23 == 0)
        {
            Console.WriteLine ("Число кратно одновременно 7 и 23.");
            return true;
        }
        else
        {
            Console.WriteLine ("Число НЕ кратно одновременно 7 и 23.");
            return false;
        }
    }
    static void Main (string[] args)
    {
        СheckMultiplicity ();
    }
}