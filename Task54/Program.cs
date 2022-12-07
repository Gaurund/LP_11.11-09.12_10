// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int Rows, int Columns, int Low, int High) MatrixParam()
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

void SortDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int position = 0; position < matrix.GetLength(1); position++)
        {
            for (int index = (position + 1); index < matrix.GetLength(1); index++)
            {
                if (matrix[i, position] < matrix[i, index])
                {
                    int temp = matrix[i, position];
                    matrix[i, position] = matrix[i, index];
                    matrix[i, index] = temp;
                }
            }
        }

    }
}

(int Rows, int Columns, int Low, int High) matrixParam = MatrixParam();
int[,] array2D = CreateMatrixRndInt(matrixParam);
PrintMatrix(matrixParam, array2D);
SortDescending(array2D);
PrintMatrix(matrixParam, array2D);
