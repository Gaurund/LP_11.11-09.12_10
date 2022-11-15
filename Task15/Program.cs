// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int InputNumber()
{
    Console.Write("Введите номер дня недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string Check(int num)
{
    if (num == 6 || num == 7) return $"{num} -> да";
    else if (num < 6 && num > 0) return $"{num} -> нет";
    return "Такого дня недели не бывает.";
}

int number = InputNumber();

Console.WriteLine(Check(number));