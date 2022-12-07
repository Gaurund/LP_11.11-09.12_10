// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// int[,] SwapRowsColumns(int[,] matrix)
// {
//     int[,] temp = new int[matrix.GetLength(1), matrix.GetLength(0)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp[j, i] = matrix[i, j];
//         }
//     }
//     return temp;
// }

// void Output(int[,] matrix)
// {
//     if (matrix.GetLength(1) == matrix.GetLength(0))
//     {
//         int[,] swappedArray = SwapRowsColumns(matrix);
//         PrintMatrix(swappedArray);
//     }
//     else
//     {
//         Console.WriteLine("\nМассив не квадратный, процедура невыполнима.");
//     }
// }

void SwapRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = temp;
        }
    }
    // return matrix;
}

void Output(int[,] matrix)
{
    if (matrix.GetLength(1) == matrix.GetLength(0))
    {
        SwapRowsColumns(matrix);
        PrintMatrix(matrix);
    }
    else
    {
        Console.WriteLine("\nМассив не квадратный, процедура невыполнима.");
    }
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, columns, -50, 50);
PrintMatrix(array2D);
Console.WriteLine();
Output(array2D);