// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    return num != 0 ? num % 10 + SumDigits(num / 10) : 0;
}

// int SumDigits(int num)
// {
//     if (num == 0) return 0;
//     return SumDigits(num / 10) + num % 10;
// }

int summer = Math.Abs(SumDigits(number));
Console.WriteLine("Сумма цифр в числе: " + summer);