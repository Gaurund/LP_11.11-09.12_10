// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void SwapFirstLastRows(int[,] matrix)
{
    int temp = 0;
    int first = 0;
    int last = matrix.GetLength(0) - 1;
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[first, i];
        matrix[first, i] = matrix[last, i];
        matrix[last, i] = temp;
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2D);
Console.WriteLine();
SwapFirstLastRows(array2D);
PrintMatrix(array2D);