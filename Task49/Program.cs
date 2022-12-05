// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int low, int high)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // Чтобы поменять порядок прохода вместо строки-столбцы на столбцы-строки, надо поменять местами вложенный цикл и внешний.
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

void PowEvenIndex(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0);i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 2, 2);
PrintMatrix(array2D);
PowEvenIndex(array2D);
Console.WriteLine();
PrintMatrix(array2D);
