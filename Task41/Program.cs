// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

// Вариант построчного ввода

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] CreateCustomArray()
{
    int size = InputNumber("Введите сколько чисел вы планируете ввести: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = InputNumber($"Введите число №{i + 1}: ");
    }
    return arr;
}

int CountPositiveNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}

void Output(int[] arr, int num)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,3}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write($" ] -> {num}\n");
}

int[] array = CreateCustomArray();
int count = CountPositiveNumbers(array);
Output(array, count);