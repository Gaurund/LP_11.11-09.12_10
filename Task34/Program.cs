// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ArraySize()
{
    int size = -1;
    while (size < 1)
    {
        size = InputNumber("Введите размер массива: ");
        if (size == 0) Console.WriteLine("\nРазмер массива не может быть равен нулю!\n");
        else if (size < 0) Console.WriteLine("\nПожалуйста, введите натуральное число.\n");
    }
    return size;
}

int[] CreateArrayRndInt(int size, int low, int high)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(low, high + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}" + ((i < arr.Length - 1) ? "," : string.Empty));
    }
    Console.Write(" ]\n");
}

int CountTwoDigit(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int arraySize = ArraySize();
int[] array = CreateArrayRndInt(arraySize, 100, 999);
PrintArray(array);
int countTwoDigit = CountTwoDigit(array);
Console.WriteLine($"Количество четных числе в массиве = {countTwoDigit}");