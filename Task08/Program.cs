// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    for (int i = 2; i <= number; i += 2)
        Console.Write($"{i} ");
}
else
{
    Console.WriteLine("Маловато будет!");
}