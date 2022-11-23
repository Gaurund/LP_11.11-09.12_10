// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Решение по заданию

// int[] FillArray(int size)
// {
//     int[] arr = new int[size];

//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(1, 100);
//     }
//     return arr;
// }

// string ArrayToString(int[] arr)
// {
//     string result = "Массив из восьми псевдослучайных чисел:\n[ ";
//     for (int i = 0; i < (arr.Length - 1); i++)
//     {
//         result += $"{arr[i]}, ";
//     }
//     result += $"{arr[arr.Length - 1]} ]";
//     return result;
// }

// int arraySize = 8;
// int[] array = FillArray(arraySize);
// string output = ArrayToString(array);

// Console.WriteLine(output);


// Универсальное решение

int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayParam()
{
    int[] arr = new int[3];

    while (arr[0] < 1)
    {
        arr[0] = InputNumber("Введите размер массива: ");
        if (arr[0] == 0) Console.WriteLine("\nРазмер массива не может быть равен нулю!\n");
        else if (arr[0] < 0) Console.WriteLine("\nПожалуйста, введите натуральное число.\n");
    }

    while (CheckEqual(arr))
    {
        arr[1] = InputNumber("Введите минимальное значение для числа в массиве: ");
        arr[2] = InputNumber("Введите максимальное значение для числа в массиве: ");
        if (CheckEqual(arr)) Console.WriteLine("\nНижний и верхний пределы равны.\nПовторите ввод.\n");
    }
    if (CheckLess(arr)) SwapParam(arr);
    arr[2] += 1;
    return arr;
}   

bool CheckLess(int[] arr)
{
    return arr[1] > arr[2];
}

bool CheckEqual(int[] arr)
{
    return arr[1] == arr[2];
}

int[] SwapParam(int[] arr)
{
    int temp = arr[2];
    arr[2] = arr[1];
    arr[1] = temp;
    Console.WriteLine("\nВы немного напутали, но мы все исправили.");
    return arr;
}

int[] FillArray(int[] arrParam)
{
    int size = arrParam[0];
    int low = arrParam[1];
    int high = arrParam[2];

    int[] arr = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(low, high);
    }
    return arr;
}

string PrepareOutput(int[] arr)
{
    string result = $"\nМассив из {arr.Length} элементов:\n[ ";
    int stepBack = arr.Length - 1;
    for (int i = 0; i < stepBack; i++)
    {
        result += $"{arr[i]}, ";
    }
    result += $"{arr[stepBack]} ]\n";
    return result;
}

void Output()
{
    int[] arrParam = ArrayParam();
    int[] arr = FillArray(arrParam);
    string output = PrepareOutput(arr);

    Console.WriteLine(output);
}

Output();