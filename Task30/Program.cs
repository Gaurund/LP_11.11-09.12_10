// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int InputNumber()
{
    int num = 0;
    while (num == 0)
    {
        Console.Write("Введите размер массива: ");
        num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        if (num == 0) Console.WriteLine("\nРазмер массива не может быть равен нулю!\n");
    }
    return num;
}

int[] FillArray(int size)
{
    int[] arr = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

string ArrayToString(int[] arr)
{
    string result = "[ ";
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        result += $"{arr[i]}, ";
    }
    result += $"{arr[arr.Length - 1]} ]";
    return result;
}

int arraySize = InputNumber();
int[] array = FillArray(arraySize);
string output = ArrayToString(array);

Console.WriteLine(output);