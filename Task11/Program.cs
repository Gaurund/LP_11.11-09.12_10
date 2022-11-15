// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

// int cut = ((number / 100) * 10 + number % 10);
// Console.WriteLine($"{number} -> {cut}");

int RidOfSecondDigit(int num)
{
    return ((num / 100) * 10 + num % 10);
}

Console.WriteLine($"{number} -> {RidOfSecondDigit(number)}");