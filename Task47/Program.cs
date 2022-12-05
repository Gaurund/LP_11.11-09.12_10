// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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

int CountShift(int low, int high, int precision)
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
    shift += precision + 3;
    return shift;
}


double[,] CreateMatrixRndDouble((int rows, int columns, int low, int high, int precision) param)
{
    double[,] matrix = new double[param.rows, param.columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (param.high - param.low) + param.low), param.precision);
        }
    }
    return matrix;
}

void PrintMatrixDouble((int, int, int low, int high, int precision) param, double[,] matrix)
{
    int shift = CountShift(param.low, param.high, param.precision);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("\n[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0," + shift + "}", matrix[i, j]);
        }
        Console.Write("  ]");
    }
    Console.WriteLine();
}

(int, int, int, int, int) matrixParam = MatrixParam();
double[,] array2D = CreateMatrixRndDouble(matrixParam);
PrintMatrixDouble(matrixParam, array2D);
