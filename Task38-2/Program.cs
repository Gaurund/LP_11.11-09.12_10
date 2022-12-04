// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

(int Size, int Low, int High, int Precision) ArrayParam()
{
    int size = 0;
    while (size < 1)
    {
        size = InputNumber("Введите размер массива: ");
        if (size == 0) Console.WriteLine("\nРазмер массива не может быть равен нулю!\n");
        else if (size < 0) Console.WriteLine("\nПожалуйста, введите натуральное число.\n");
    }

    int low = 0;
    int high = 0;
    while (low == high)
    {
        low = InputNumber("Введите минимальное значение для числа в массиве: ");
        high = InputNumber("Введите максимальное значение для числа в массиве: ");
        if (low == high) Console.WriteLine("\nНижний и верхний пределы равны.\nПовторите ввод.\n");
    }
    if (low > high) SwapParam(low, high);
    high += 1;

    int precision = Math.Abs(InputNumber("Введите до какого знака после запятой будут округлятся дроби: "));

    return (size, low, high, precision);
}

(int Low, int High) SwapParam(int low, int high)
{
    int temp = high;
    high = low;
    low = temp;
    return (low, high);
}

double[] CreateArrayRndDouble((int size, int low, int high, int precision) param)
{
    double[] arr = new double[param.size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (param.high - param.low) + param.low), param.precision);
    }
    return arr;
}

int CountShift((int, int low, int high, int precision) param)
{
    int number = param.high;
    if (Math.Abs(param.low) > Math.Abs(param.high)) number = param.low;

    int shift = 0;
    while (number != 0)
    {
        number /= 10;
        shift++;
    }
    if (param.low < 0) shift += 1;
    shift += param.precision + 1;
    return shift;
}

void PrintArrayDouble(double[] arr, (int, int, int, int) param)
{
    int shift = CountShift(param);
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0," + $"{shift}" + "}", arr[i]);
        Console.Write((i < arr.Length - 1) ? " |" : string.Empty);
    }
    Console.Write(" ]\n");
}

(double Min, double Max) SearchMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    return (min, max);
}

double MaxMinusMin((double min, double max) minMax, int precision)
{
    double result = Math.Round((minMax.max - minMax.min), precision);
    return result;
}

(int Size, int Low, int High, int Precision) arrayParam = ArrayParam();
double[] array = CreateArrayRndDouble(arrayParam);
PrintArrayDouble(array, arrayParam);
(double Min, double Max) arrayMinMax = SearchMinMax(array);
double maxMinusMin = MaxMinusMin(arrayMinMax, arrayParam.Precision);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива = {maxMinusMin}");