// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int isSquareNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь введите второе число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number * number) == isSquareNumber)
{
    Console.WriteLine($"Да, {isSquareNumber} это квадрат {number}.");
}
else
{
    Console.WriteLine($"Нет, {isSquareNumber} это не квадрат {number}.");
}

