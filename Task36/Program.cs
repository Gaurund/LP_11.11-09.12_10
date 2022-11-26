// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int[] CreateArrayRndIntCustom(int[] arrParam)
{
    int size = arrParam[0];
    int low = arrParam[1];
    int high = arrParam[2];

    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(low, high + 1);
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
    count += 1;
    return count;
}

void PrintArray(int[] arr, int[] arrParam)
{
    int shift = CountShift(arrParam);
    
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,"+$"{shift}"+"}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write(" ]\n");
}

int SumOddNumbers(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    return result;
}

int[] arrayParam = ArrayParam();
int[] array = CreateArrayRndIntCustom(arrayParam);
PrintArray(array, arrayParam);
int sumOddNumbers = SumOddNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях. = {sumOddNumbers}");