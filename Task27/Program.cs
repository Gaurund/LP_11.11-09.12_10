// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber()
{
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumDigits(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return Math.Abs(result);
}

void Output(int num)
{
    int sum = SumDigits(num);
    Console.WriteLine($"{num} -> {sum}");
}

int number = InputNumber();

Output(number);
