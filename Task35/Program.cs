// Задача 35. Задайте одомерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14]->5

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
        Console.Write("{0,4}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write(" ]");
}

int CountTwoDigits(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(123, -199, 199);
PrintArray(array);
int countTwoDigits = CountTwoDigits(array);
Console.WriteLine($"\nВсего чисел в отрезке от 10 до 99: {countTwoDigits}");
