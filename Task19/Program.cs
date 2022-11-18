// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNumber()
{
    int num = 0;
    while (CheckInput(num))
    {
        Console.Write("Введите пятизначное число: ");
        num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        if (CheckInput(num)) Console.Write("Это не пятизначное число!\n");
    };

    return num;
}

bool CheckInput(int num)
{
    return num > 99999 || num < 10000;
}

int Reverse(int num)
{
    int numRev = 0;
    for (int i = 0; num > 0; i++)
    {
        int remainder = num % 10;
        num = num / 10;
        numRev = numRev * 10 + remainder;

    }
    return numRev;
}

bool CheckPalindrome()
{
    int number = InputNumber();
    int reversed = Reverse(number);
    return number == reversed;
}

void Output()
{

    if (CheckPalindrome()) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

Output();