// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int Rows, int Columns) MatrixParam()
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

    return (row, col);
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть отрицательным. Повторите ввод.\n");
}

int[,] CreateCustomEmptyMatrix((int row, int col) param)
{
    int[,] matrix = new int[param.row, param.col];
    return matrix;
}

int[,] FillMatrixSpiral(int[,] matrix)
{
    int count = 0;

    int row = 0;
    int col = 0;

    int limitBottomRow = matrix.GetLength(0);
    int limitRightCol = matrix.GetLength(1);
    // int limitTopRow = 0;
    int limitLeftCol = 0;

    while (count < matrix.Length)
    {
        matrix[row, col] = ++count;
        if (col + 1 < limitRightCol
            && matrix[row, col + 1] == 0
            && (row == 0 || matrix[row - 1, col] != 0)) col++;
        else if (row + 1 < limitBottomRow
                 && matrix[row + 1, col] == 0) row++;
        else if (col - 1 >= limitLeftCol
                 && matrix[row, col - 1] == 0) col--;
        else  row--; //if (row - 1 >= limitTopRow && matrix[row - 1, col] == 0)
    }
    return matrix;
}

int CountShift(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    count += 1;
    return count;
}

void PrintMatrix(int[,] matrix)
{
    int shift = CountShift(matrix.Length);
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

(int Rows, int Columns) matrixParam = MatrixParam();
int[,] array2D = CreateCustomEmptyMatrix(matrixParam);
FillMatrixSpiral(array2D);
PrintMatrix(array2D);