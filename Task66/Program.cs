// Задача 66: Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int MinNumber, int MaxNumber) GetMinMaxNumbers()
{
    int min = -1;
    int max = -1;
    while (min < 1)
    {
        min = InputNumber("Введите первое натуральное число: ");
        if (min < 1) ErrorNegativeNumber();
    }
    while (max < 1)
    {
        max = InputNumber("Введите второе натуральное число: ");
        if (max < 1) ErrorNegativeNumber();
    }
    if (min > max) return (max, min);
    return (min, max);
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть меньше единицы. Повторите ввод.\n");
}

int Sum(int min, int max)
{
    if (min == max) return max;
    return Sum(min, max - 1) + max;
}

void Output()
{
    (int min, int max) num = GetMinMaxNumbers();
    int sum = Sum(num.min, num.max);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {num.min} до {num.max} равна {sum}");
}

Output();