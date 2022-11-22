// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Решение по заданию

int[] FillArray(int size)
{
    int[] arr = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

string ArrayToString(int[] arr)
{
    string result = "Массив из восьми псевдослучайных чисел:\n[ ";
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        result += $"{arr[i]}, ";
    }
    result += $"{arr[arr.Length - 1]} ]";
    return result;
}

int arraySize = 8;
int[] array = FillArray(arraySize);
string output = ArrayToString(array);

Console.WriteLine(output);


// Универсальное решение


// int InputNumber(string msg)
// {
//     Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] ArrayParam()
// {
//     int[] arrParam = new int[3];

//     while (CheckLess(arrParam[0], 1))
//     {
//         arrParam[0] = InputNumber("Введите размер массива: ");
//         if (CheckEqual(arrParam[0], 0)) Console.WriteLine("\nРазмер массива не может быть равен нулю!\n");
//         else if (CheckLess(arrParam[0], 0)) Console.WriteLine("\nПожалуйста, введите натуральное число.\n");
//     }

//     while (CheckEqual(arrParam[1], arrParam[2]))
//     {
//         arrParam[1] = InputNumber("Введите минимальное значение для числа в массиве: ");
//         arrParam[2] = InputNumber("Введите максимальное значение для числа в массиве: ");
//         if (CheckEqual(arrParam[1], arrParam[2])) Console.WriteLine("\nНижний и верхний пределы равны.\nПовторите ввод.\n");
//     }
//     if (CheckLess(arrParam[2], arrParam[1])) CorrectArrayParam(arrParam);
//     arrParam[2] += 1;
//     return arrParam;
// }

// bool CheckLess(int first, int second)
// {
//     return first < second;
// }

// bool CheckEqual(int first, int second)
// {
//     return first == second;
// }

// int[] CorrectArrayParam(int[] arrParam)
// {
//     int temp = arrParam[2];
//     arrParam[2] = arrParam[1];
//     arrParam[1] = temp;
//     return arrParam;
//     // Console.WriteLine("Некорректный ввод исправлен.");
// }

// int[] FillArray(int[] arrParam)
// {
//     int size = arrParam[0];
//     int low = arrParam[1];
//     int high = arrParam[2];

//     int[] arr = new int[size];

//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(low, high);
//     }
//     return arr;
// }

// string OutputString(int[] arr)
// {
//     string result = $"\nМассив из {arr.Length} элементов:\n[ ";
//     for (int i = 0; i < (arr.Length - 1); i++)
//     {
//         result += $"{arr[i]}, ";
//     }
//     result += $"{arr[arr.Length - 1]} ]";
//     return result;
// }

// void Output()
// {
//     int[] arrayParam = ArrayParam();
//     int[] array = FillArray(arrayParam);
//     string output = OutputString(array);

//     Console.WriteLine(output);
// }

// Output();