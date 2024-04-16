//Напишите программу, которая принимает на вход целое число из
//отрезка [10, 99] и показывает наибольшую цифру числа.

using System;

class Program
{
    static void Main()
    {
        MaxNumber();
    }
    static void MaxNumber()
    {
         Console.WriteLine("Введите число от 10 до 99: ");
         if (int.TryParse(Console.ReadLine(), out int num))
         {
            if (num >= 10 && num <= 99)
            {
                char maxDigit = '0';
                foreach (char digit in num.ToString())
                {
                    if (digit > maxDigit)
                        maxDigit = digit;                   
                }
                Console.WriteLine($"Наибольшая цифра в числе: {maxDigit}");
            } 
            else
            {
                Console.WriteLine("Число должно быть от 10 до 99");
                MaxNumber ();
            }
         }
         else
         {
            Console.WriteLine("Некорректно. Введите, пожалуйста, число от 10 до 99: ");
            MaxNumber ();
         }
    }

}
