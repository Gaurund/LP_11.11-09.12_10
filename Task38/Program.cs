// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

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

bool CheckEqual(int[] arr)
{
    return arr[1] == arr[2];
}

bool CheckLess(int[] arr)
{
    return arr[1] > arr[2];
}

int[] SwapParam(int[] arr)
{
    int temp = arr[2];
    arr[2] = arr[1];
    arr[1] = temp;
    return arr;
}

double[] CreateArrayRndDouble(int[] arrParam)
{
    int size = arrParam[0];
    int low = arrParam[1];
    int high = arrParam[2];

    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (high - low) + low), 1);
    }
    return arr;
}

int CountShift(int[] arr)
{
    int low = arr[1];
    int high = arr[2];

    int number = high;
    if (Math.Abs(low) > Math.Abs(high)) number = low;

    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    if (low < 0) count += 1;
    count += 2;
    return count;
}

void PrintArrayDouble(double[] arr, int[] arrParam)
{
    int shift = CountShift(arrParam);
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0," + $"{shift}" + "}", arr[i]);
        Console.Write((i < arr.Length - 1) ? " |" : string.Empty);
    }
    Console.Write(" ]\n");
}

double[] SearchMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    double[] arrMinMax = { min, max };
    return arrMinMax;
}

double MaxMinusMin(double[] arr)
{
    double min = arr[0];
    double max = arr[1];

    double result = Math.Round((max - min), 1);
    return result;
}

int[] arrayParam = ArrayParam();
double[] array = CreateArrayRndDouble(arrayParam);
PrintArrayDouble(array, arrayParam);
double[] arrayMinMax = SearchMinMax(array);
double maxMinusMin = MaxMinusMin(arrayMinMax);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива = {maxMinusMin}");