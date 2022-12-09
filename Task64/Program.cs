// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetNumber()
{
    int num = -1;
    while (num < 1)
    {
        num = InputNumber("Введите натуральное число: ");
        if (num < 1) ErrorNegativeNumber();
    }
    return num;
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть меньше единицы. Повторите ввод.\n");
}

void NaturalNumbersBackwards(int num)
{
    if (num != 0)
    {
        Console.Write(num != 1 ? $"{num}, " : num);
        NaturalNumbersBackwards(num - 1);
    }
}

void Output()
{
    int num = GetNumber();
    Console.Write("N = " + num + " -> ");
    NaturalNumbersBackwards(num);
}

Output();