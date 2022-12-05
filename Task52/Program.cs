// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int, int, int, int, int) MatrixParam()
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
    int precision = -1;
    while (precision < 0)
    {
        precision = InputNumber("До какого знака после запятой округляем? ");
        if (precision < 0) ErrorNegativeNumber();
    }
    return (row, col, low, high, precision);
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть отрицательным. Повторите ввод.\n");
}

int CountShift((int, int, int low, int high, int precision) param)
{
    int number = param.high;
    if (Math.Abs(param.low) > Math.Abs(param.high)) number = param.low;

    int shift = 0;
    while (number != 0)
    {
        number /= 10;
        shift++;
    }
    if (param.low < 0) shift += 1;
    shift += param.precision + 2;
    return shift;
}

int[,] CreateMatrixRndInt((int row, int col, int low, int high, int) param)
{
    int[,] matrix = new int[param.row, param.col];
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

double[] ColumnAverage(int precision, int[,] matrix)
{
    double[] aver = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            aver[j] += Convert.ToDouble(matrix[i, j]);
        }
        aver[j] = Math.Round((aver[j] / matrix.GetLength(0)), precision);
    }
    return aver;
}

void PrintMatrix(int shift, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0," + shift + "}", matrix[i, j]);
            Console.Write((j < matrix.GetLength(1) - 1) ? " |" : string.Empty);
        }
        Console.Write(" ]\n");
    }
}

void PrintArrayDouble(int shift, double[] aver)
{
    Console.Write("[");
    for (int i = 0; i < aver.Length; i++)
    {
        Console.Write("{0," + shift + "}", aver[i]);
        Console.Write((i < aver.Length - 1) ? " |" : string.Empty);
    }
    Console.Write(" ]");
}

void Output(int shift, int[,] matrix, double[] aver)
{
    Console.WriteLine("\nМатрица:");
    PrintMatrix(shift, matrix);
    Console.WriteLine("Среднее арифметическое по столбцам:");
    PrintArrayDouble(shift, aver);
    Console.WriteLine();
}

(int, int, int, int, int Precision) arrayParam = MatrixParam();
int[,] array2D = CreateMatrixRndInt(arrayParam);
int shiftTab = CountShift(arrayParam);
double[] colAverage = ColumnAverage(arrayParam.Precision, array2D);

Output(shiftTab, array2D, colAverage);
