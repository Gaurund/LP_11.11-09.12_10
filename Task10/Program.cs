// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Пожалуйста, введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit (int num)
{
    int secondDigit = (num - ((num/100)*100))/10;
    return secondDigit;
}

Console.WriteLine(SecondDigit(number));