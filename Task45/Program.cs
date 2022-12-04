// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

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
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,3}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write(" ]\n");
}

int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    copy[0] = 66; // Контроль вывода копии. 
    return copy;
}

int[] array = CreateArrayRndInt(8,1,10);
PrintArray(array);
int[] copyArray = CopyArray(array);
PrintArray(copyArray);