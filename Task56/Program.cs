// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void PrintMatrix(int[,] matrix, int shift)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"\n{i + 1} - [");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0," + shift + "}", matrix[i, j]);
            Console.Write((j < matrix.GetLength(1) - 1) ? "," : string.Empty);
        }
        Console.Write(" ]");
    }
    Console.WriteLine("\n");
}

int SearchMinSumRow(int[,] matrix)
{
    int minSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0, j];
    }
    int rowPointer = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            rowPointer = i;
        }
    }
    return rowPointer;
}

void Output(int num)
{
    Console.WriteLine($"{num + 1} cтрока содержит наименьшую сумму в массиве.");
}

(int Rows, int Columns, int Low, int High) matrixParam = MatrixParam();
int[,] array2D = CreateMatrixRndInt(matrixParam);
int shiftTab = CountShift(matrixParam.Low, matrixParam.High);
PrintMatrix(array2D, shiftTab);
int minSumRow = SearchMinSumRow(array2D);
Output(minSumRow);