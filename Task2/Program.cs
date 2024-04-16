//Напишите программу, которая принимает на вход координаты точки
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в
// которой находится эта точка.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координату Х: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой четверти системы координат.");
        }
        else if (x < 0 && y > 0) 
        {
            Console.WriteLine("Точка находится во второй четверти системы координат.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей четверти системы координат.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвертой четверти системы координат.");
        }
    }
}