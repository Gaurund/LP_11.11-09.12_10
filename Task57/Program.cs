﻿// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateMatrixRndInt(int rows, int columns, int low, int high)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(low, high + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("\n[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
            Console.Write((j < matrix.GetLength(1) - 1) ? "," : string.Empty);
        }
        Console.Write(" ]");
    }
}

void PrintArray(int[] arr)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,4}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write(" ]\n");
}

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i, j];
        }
    }
    return arr;
}

int[,] StoreValueAndPosition(int[] arr)
{
    int[,] storeValPos = new int[arr.Length, 2];
    int count = 0;
    int val = arr[0];
    int j = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        count++;
        if (arr[i] != val)
        {
            storeValPos[j, 0] = val;
            storeValPos[j++, 1] = count;
            count = 0;
            val = arr[i];
        }
    }
    storeValPos[j, 0] = arr[arr.Length-1];
    storeValPos[j, 1] = ++count;

    return storeValPos;
}

void PrintResults(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 1] == 0) return;
        Console.WriteLine($"{result[i, 0]} встречается {result[i, 1]} раз.");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2D);
int[] array = MatrixToArray(array2D);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int[,] resultArray = StoreValueAndPosition(array);
PrintResults(resultArray);
