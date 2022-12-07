// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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

(int Row, int Column) SearchMinValue(int[,] matrix)
{
    int row = 0;
    int col = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                row = i;
                col = j;
            }
        }
    }
    return (row, col);
}


int[,] DeleteMinValueRowCol(int[,] matrix, (int row, int col) minValue)
{
    int[,] crop = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0,  k = 0; i < crop.GetLength(0); i++, k++)
    {
        if (i == minValue.row) k++;
        for (int j = 0, m = 0; j < crop.GetLength(1); j++, m++)
        {
            if (j == minValue.col) m++;
            crop[i, j] = matrix[k, m];
        }
    }
    return crop;
}

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);
(int Row, int Column) minValue = SearchMinValue(array2D);
Console.WriteLine();
Console.WriteLine($"\nКоординаты минимального значения: {minValue.Row}, {minValue.Column}");
int[,] croppedArray = DeleteMinValueRowCol(array2D, minValue);
PrintMatrix(croppedArray);