// Напишите программу, которая на вход принимает натуральное число
// N, а на выходе показывает его цифры через запятую.

using System;
class Program
{
    static void Main()
    {
        SeparateNumber();
    }
    static void SeparateNumber()
    {
        Console.WriteLine("Запишите число: ");
        string someNum = Console.ReadLine();

        if (int.TryParse(someNum, out int num))
        {
            foreach (char digit in someNum)
            {
                Console.Write(digit + ",");
            }
            Console.WriteLine();
        }
        else 
        {
            Console.WriteLine("Некорректно. Введите число.");
            SeparateNumber();
        }
    }

}    