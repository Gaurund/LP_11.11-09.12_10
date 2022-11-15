﻿// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int InputNumber()
{
    Console.Write("Пожалуйста, введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ThreeDigits(int num)
{
    num = Math.Abs(num);
    return num < 1000 && num > 99;
}

int SecondDigit(int num)
{
    return Math.Abs(num) / 10 % 10;
}

void Output()
{
    int number = InputNumber();
    bool threeDigits = ThreeDigits(number);
    if (threeDigits)
    {
        Console.WriteLine($"{number} -> {SecondDigit(number)}");
    }
    else
    {
        Console.WriteLine("Число должно быть трёхзначным!");
    }

}

Output();

// int InputNumber()
// {
//     Console.Write("Пожалуйста, введите трёхзначное число: ");
//     int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     return number;
// }

// string SecondDigit(int num)
// {
//     if (num > 1000 || num < 100)
//     {
//         return "Число должно быть трёхзначным!";
//     }
//     num = num / 10 % 10;
//     return $"{num}";
// }

// int number = InputNumber();

// Console.WriteLine(SecondDigit(number));