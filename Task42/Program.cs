// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return num;
}

int DecToBin(int num)
{
    int temp = 1;

    while (num != 0)
    {
        temp = temp * 10 + num % 2;
        num /= 2;
    }

    while (temp != 0)
    {
        num = num * 10 + temp % 10;
        temp /= 10;
    }
    num /= 10;

    return num;
}

// int[] DecToBin(int num)
// {
//     int div = 2;
//     int size = CountDigits(num, div);

//     int[] arr = new int[size];
//     for (int i = size; i > 0; i--)
//     {
//         arr[i - 1] = num % div;
//         num /= div;
//     }

//     return arr;
// }

// int CountDigits(int num, int divider)
// {
//     int result = 0;
//     while (num != 0)
//     {
//         num /= divider;
//         result++;
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//     }
// }

int number = InputNumber("Введите десятичное число: ");
Console.WriteLine("Двоичное представление числа: " + DecToBin(number));

// int[] binArray = DecToBin(number);
// PrintArray(binArray);