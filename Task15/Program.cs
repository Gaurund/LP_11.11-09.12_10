// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// 1 вариант

// int InputNumber()
// {
//     Console.Write("Введите номер дня недели: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// string Check(int num)
// {
//     if (num == 6 || num == 7) return $"{num} -> да";
//     if (num < 6 && num > 0) return $"{num} -> нет";
//     return "Такого дня недели не бывает.";
// }

// int number = InputNumber();

// Console.WriteLine(Check(number));

int InputNumber()
{
    Console.Write("Введите номер дня недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ProperInput(int num)
{
    return num < 1 || num > 7;
}

bool IsWeekend(int num)
{
    return num > 5;
}

string Output(int num)
{
    string str = $"{num} -> нет";
    if (ProperInput(num)) str = "Такого дня недели не бывает.";
    else if (IsWeekend(num)) str = $"{num} -> да";
    return str;
}

Console.WriteLine(Output(InputNumber()));