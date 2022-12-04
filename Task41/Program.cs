// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

// Вариант построчного ввода

// int InputNumber(string msg)
// {
//     Console.Write(msg);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[] CreateCustomArray()
// {
//     int size = InputNumber("Введите сколько чисел вы планируете ввести: ");
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = InputNumber($"Введите число №{i + 1}: ");
//     }
//     return arr;
// }

// int CountPositiveNumbers(int[] arr)
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) result++;
//     }
//     return result;
// }

// void Output(int[] arr, int num)
// {
//     Console.Write("\n[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write("{0,3}", arr[i]);
//         Console.Write((i < arr.Length - 1) ? "," : string.Empty);
//     }
//     Console.Write($" ] -> {num}\n");
// }

// int[] array = CreateCustomArray();
// int count = CountPositiveNumbers(array);
// Output(array, count);

// Вариант ввода чисел одной строкой через запятую.

string InputString(string msg)
{
    Console.Write(msg);
    string str = Console.ReadLine() ?? "";
    return str;
}

int[] ExplodeStringToIntegers(string str)
{
    string[] strArr = str.Split(",");
    int[] arr = new int[strArr.Length];
    for (int i = 0; i < strArr.Length; i++)
    {
         arr[i] = Convert.ToInt32(strArr[i]);
    }
    return arr;
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void Output(int[] arr, int num)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,3}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write($" ] -> {num}\n");
}

string stringOfNumbers = InputString("Пожалуйста, введите несколько целых чисел через запятую: ");
int[] array = ExplodeStringToIntegers(stringOfNumbers);
int counter = CountPositiveNumbers(array);
Output(array, counter);