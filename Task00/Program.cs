// Задача 0. Напишите программу, которая на вход принимает число и выдаёт его квадрат

Console.WriteLine("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.WriteLine($"Квадрат числа {number} = {square}");