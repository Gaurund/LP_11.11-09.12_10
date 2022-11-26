// Задача 32. Напишите программу по замене элементов массива: 
// положительные элементы заменита на соотвествющие отрицательные и наоборот.
// [-4,8,8,2] -> [4,8,-8,-2]

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

void InverseSignInArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = CreateArrayRndInt(8, -10, 10);
PrintArray(array);
InverseSignInArray(array);
Console.WriteLine();
PrintArray(array);
