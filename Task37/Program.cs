// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
    Console.Write(" ]\n");
}

int[] MultipliedArray(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] arrNew = new int[size];
    int limit = arr.Length - 1;
    for (int i = 0; i <= limit; i++)
    {
        if (i == limit) arrNew[i] = arr[i];
        else
        {
            arrNew[i] = arr[i] * arr[limit];
            limit--;
        }
    }
    return arrNew;
}

int[] array = CreateArrayRndInt(8, 1, 10);
PrintArray(array);
int[] multipliedArray = MultipliedArray(array);
PrintArray(multipliedArray);