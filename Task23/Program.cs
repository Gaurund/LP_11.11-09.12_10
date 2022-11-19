// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Решение по заданию

int InputNumber()
{
    Console.Write("Пожалуйста, введите целое положительное число: ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return num;
}

void Output(int num)
{
    for (int count = 1; count <= num; count++)
    {
        double pow = Math.Pow(count, 3);
        Console.WriteLine($"{count} | {pow}");
    }
}

int number = InputNumber();

Output(number);

// Решение с произвольной степенью

// int InputNumber(string message)
// {
//     Console.Write(message);
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     return num;
// }

// void Output(int num, int pow)
// {
//     for (int count = 1; count <= num; count++)
//     {
//         double calc = Math.Pow(count, pow);
//         Console.WriteLine($"{count} | {calc}");
//     }
// }

// int number = InputNumber("Пожалуйста, введите целое положительное число: ");
// int power = InputNumber("В какую степень хотите возвести? Введите её: ");

// Output(number, power);