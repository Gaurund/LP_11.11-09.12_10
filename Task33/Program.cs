// Задача 33. Задайте массив. Напишите программу, которая 
// определеят, присутссвует ли заднное число в массиве.

// 4; [6,7,19,345,3] -> нет
// 3; [6,7,19,345,3] -> да

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

bool IsNumberHere(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}


int[] array = CreateArrayRndInt(8, -10, 10);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомое числоа: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isNumberHere = IsNumberHere(array, number);
Console.WriteLine(isNumberHere ? "Да" : "Нет");