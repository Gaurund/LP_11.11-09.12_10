// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Универсальный вариант.

int InputNumber()
{
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Reverse(int num)
{
    int rev = 0;
    while (num != 0)
    {
        rev = rev * 10 + num % 10;
        num /= 10;
    }
    return rev;
}

bool CheckPalindrome(int num)
{
    int rev = Reverse(num);
    return num == rev;
}

void Output()
{
    int num = InputNumber();
    if (CheckPalindrome(num)) Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}

Output();


// Вариант с проверкой на пятизначность.

// int InputNumber()
// {
//     int num = 0;
//     while (CheckInput(num))
//     {
//         Console.Write("Введите целое пятизначное число: ");
//         num = Convert.ToInt32(Console.ReadLine());
//         if (CheckInput(num)) Console.Write("Это не пятизначное число!\n");
//     };

//     return num;
// }

// bool CheckInput(int num)
// {
//     num = Math.Abs(num);
//     return num > 99999 || num < 10000;
// }

// int Reverse(int num)
// {
//     int rev = 0;
//     while (num != 0)
//     {
//         rev = rev * 10 + num % 10;
//         num /= 10;
//     }
//     return rev;
// }

// bool CheckPalindrome(int num)
// {
//     int rev = Reverse(num);
//     return num == rev;
// }

// void Output()
// {
//     int num = InputNumber();
//     if (CheckPalindrome(num)) Console.WriteLine($"{num} -> да");
//     else Console.WriteLine($"{num} -> нет");
// }

// Output();