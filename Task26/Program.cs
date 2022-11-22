// Задача 26. Напишите программу, которая 
// принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputNumber()
{
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int CountDigits(int num)
{
    int i = 1;
    while (num != 0)
    {
        num /= 10;
        i++;
    }
    return i - 1;
}

int number = InputNumber();
int counter = CountDigits(number);

Console.WriteLine($"{number} -> {counter}");