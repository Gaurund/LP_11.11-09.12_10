// Задача 31. Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка -9, 9. 
// Вывести массив
// Найдите сумму отрицательных 
// и положительных элементов массива.

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
        Console.Write("{0,3}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write(" ]");
}

// int[] GetSums(int[] arr)
// {
//     int pos = 0;
//     int neg = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) pos += arr[i];
//         else neg += arr[i];
//     }
//     int[] result = { pos, neg };
//     return result;
// }

int GetSums(int[] arr, bool plus, bool minus)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0 && plus) result += arr[i];
        if (arr[i] < 0 && minus) result += arr[i];
    }
    return result;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int positiveSum = GetSums(array, plus: true, minus: false);
int negativeSum = GetSums(array, plus: false, minus: true);
// int[] sums = GetSums(array);
// Console.Write($"\nСумма положительных чисел: {sums[0]}.\nСумма отрицательных чисел: {sums[1]}.");
Console.Write($"\nСумма положительных чисел: {positiveSum}.\nСумма отрицательных чисел: {negativeSum}.");