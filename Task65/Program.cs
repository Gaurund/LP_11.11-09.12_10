// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите первое натуральное число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int numFirst, int numSec)
{
    int sign = 1;
    if (numFirst > numSec) sign = -1;
    
    if (numSec != numFirst)
    {
        NaturalNumbers(numFirst, numSec - 1 * sign);
        Console.Write($"{numSec} ");
    }
    else Console.Write($"{numSec} ");
}

NaturalNumbers(numberFirst, numberSecond);