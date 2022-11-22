// Задача 24: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму чисел от одного до этого числа.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputNumber()
{
    Console.Write("Введите целое положительное число: ");
    // int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int number = InputNumber();
if (number > 0)
{
    int sumDigits = SumDigits(number);
    Console.WriteLine($"{number} -> {sumDigits}");
}
else
{
    Console.WriteLine("Требуется ввести натуральное число.");
}