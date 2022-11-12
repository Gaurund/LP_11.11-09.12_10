// Задача 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
    int last = Math.Abs(number % 10);
    Console.WriteLine($"Последнее число это {last}");
} else {
    Console.WriteLine("Введённое число не соответствует запросу.");
}

