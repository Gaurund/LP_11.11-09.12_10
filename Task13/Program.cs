// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Вариант без методов

// Console.Write("Введите целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else
// {
//     while (number > 1000)
//     {
//         number = number / 10;
//     }

//     int third = number % 10;
//     Console.WriteLine(third);
// }

// Вариант с методами

int InputNumber()
{
    Console.Write("Введите целое положительное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int DecreaseToThreeDigits(int num)
{
    for (; num > 1000; num /= 10); 

    return num;
}

string Check(int num)
{
    if (num > 99)
    {
        int third = (DecreaseToThreeDigits(num) % 10);
        return $"{num} -> {third}";
    }
    return $"{num} -> третьей цифры нет";
}


int number = InputNumber();


Console.WriteLine(Check(number));