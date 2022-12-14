// Код написан Alexander Alexandrovich

int[,] GetArray(int row, int col)
{
    int[,] result = new int[row, col];
    int i = 0;
    int j = 0;
    int rowE = row - 1;
    int columnE = col - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < row * col)
    {
        count++;
        result[i, j] = count;
        //идем вправо
        if (left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //идем вниз
        if (!left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //идем влево
        if (!left && !top)
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //Идем вверх
        if (left && !top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }

    }
    return result;
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

int[,] array2D=GetArray(14,10);
PrintMatrix(array2D);