// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int, int) GetPoint()
{
    int row = -1;
    int col = -1;
    while (row < 0)
    {
        row = InputNumber("Введите индекс строки элемента: ");
        if (row < 0) ErrorNegativeNumber();
    }
    while (col < 0)
    {
        col = InputNumber("Введите индекс столбца элемента: ");
        if (col < 0) ErrorNegativeNumber();
    }
    return (row, col);
}

(int, int, int, int) MatrixParam()
{
    int row = -1;
    int col = -1;
    while (row < 0)
    {
        row = InputNumber("Введите сколько строк будет в матрице: ");
        if (row < 0) ErrorNegativeNumber();
    }
    while (col < 0)
    {
        col = InputNumber("Введите сколько столбцов будет в матрице: ");
        if (col < 0) ErrorNegativeNumber();
    }
    int low = InputNumber("Введите минимальное значение элемента: ");
    int high = InputNumber("Введите максимальное значение элемента: ");
    return (row, col, low, high);
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть отрицательным. Повторите ввод.\n");
}

int CountShift(int low, int high)
{
    int number = high;
    if (Math.Abs(low) > Math.Abs(high)) number = low;

    int shift = 0;
    while (number != 0)
    {
        number /= 10;
        shift++;
    }
    if (low < 0) shift += 1;
    return ++shift;
}

int[,] CreateMatrixRndInt((int rows, int columns, int low, int high) param)
{
    int[,] matrix = new int[param.rows, param.columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(param.low, param.high + 1);
        }
    }
    return matrix;
}

void PrintMatrix((int rows, int columns, int low, int high) param, int[,] matrix)
{
    int shift = CountShift(param.low, param.high);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"\n[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0," + shift + "}", matrix[i, j]);
            Console.Write((j < matrix.GetLength(1) - 1) ? "," : string.Empty);
        }
        Console.Write(" ]");
    }
    Console.WriteLine("\n");
}

void Output((int row, int col) indxs, int[,] matrix)
{
    if (indxs.row >= matrix.GetLength(0) || indxs.col >= matrix.GetLength(1))
    {
        Console.WriteLine($"\n{indxs.row}, {indxs.col} -> Такого элемента в массиве нет.");
    }
    else
    {
        Console.WriteLine($"\n{indxs.row}, {indxs.col} -> {matrix[indxs.row, indxs.col]}");
    }
}

(int, int, int, int) matrixParam = MatrixParam();
int[,] array2D = CreateMatrixRndInt(matrixParam);
PrintMatrix(matrixParam, array2D);
(int, int) pointer = GetPoint();
Output(pointer, array2D);