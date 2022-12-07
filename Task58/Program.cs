// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void PrintMatrix(int shift, int[,] matrix)
{
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

bool IsMatrixMultiplPossible(int firstMatrixColumns, int secondMatrixRows)
{
    return firstMatrixColumns == secondMatrixRows;
}

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] productMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                productMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return productMatrix;
}

void Output(int shift, int firstMatrixColumns, int secondMatrixRows, int[,] firstMatrix, int[,] secondMatrix)
{
    if (IsMatrixMultiplPossible(firstMatrixColumns, secondMatrixRows))
    {
        int[,] productMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
        Console.WriteLine("Результат умножения матриц:");
        PrintMatrix(shift, productMatrix); // Надо разобраться с подсчётом сдвига в форматировании.
    }
    else
    {
        Console.WriteLine("Матрицы нельзя перемножить, потому что количество столбцов первой матрицы не равно количеству строк во второй.");
    }
}

Console.WriteLine("\nВведите параметры первой матрицы");
(int Rows, int Columns, int Low, int High) firstMatrixParam = MatrixParam();
Console.WriteLine("\nВведите параметры второй матрицы");
(int Rows, int Columns, int Low, int High) secondMatrixParam = MatrixParam();

int[,] firstArray2D = CreateMatrixRndInt(firstMatrixParam);
int[,] secondArray2D = CreateMatrixRndInt(secondMatrixParam);

int shiftFirst = CountShift(firstMatrixParam.Low, firstMatrixParam.High);
int shiftSecond = CountShift(secondMatrixParam.Low, secondMatrixParam.High);

int shiftProduct = CountShift(firstMatrixParam.Low * secondMatrixParam.Low,
                              firstMatrixParam.High * secondMatrixParam.High);

Console.WriteLine("\nПервая матрица");
PrintMatrix(shiftFirst, firstArray2D);
Console.WriteLine("Вторая матрица");
PrintMatrix(shiftSecond, secondArray2D);

Output(shiftProduct, firstMatrixParam.Columns, secondMatrixParam.Rows, firstArray2D, secondArray2D);