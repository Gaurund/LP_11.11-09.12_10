// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return num;
}

// void Fibonacci(int num)
// {
//     int result = 0;
//     int num1 = 0;
//     int num2 = 1;
//     if (num > 0) Console.Write(num1 + " ");
//     if (num > 1) Console.Write(num2 + " ");
//     if (num > 2)
//     {
//         while (num > 2)
//         {
//             result = num1 + num2;
//             num1 = num2;
//             num2 = result;
//             num--;
//             Console.Write(result + " ");
//         }
//     }
// }

int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    if (num == 1) return arr;
    arr[1] = 1;

    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,3}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write(" ]\n");
}

int number = InputNumber("Введите число до которого нужно показать ряд Фибоначчи: ");
int[] array = Fibonacci(number);
PrintArray(array);

// Fibonacci(number);