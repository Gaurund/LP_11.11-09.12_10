// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int Rows, int Columns, int Depth) Array3DParam()
{
    int row = -1;
    int col = -1;
    int depth = -1;

    while (row < 1)
    {
        row = InputNumber("Введите сколько строк будет в массиве: ");
        if (row < 1) ErrorNegativeNumber();
    }

    while (col < 1)
    {
        col = InputNumber("Введите сколько столбцов будет в массиве: ");
        if (col < 1) ErrorNegativeNumber();
    }

    while (depth < 1)
    {
        depth = InputNumber("Введите сколько страниц будет в массиве: ");
        if (depth < 1) ErrorNegativeNumber();
    }

    return (row, col, depth);
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть меньше единицы. Повторите ввод.\n");
}

int[,,] CreateArray3D((int row, int col, int depth) param)
{
    int[,,] arr3D = new int[param.row, param.col, param.depth];
    return arr3D;
}

void FillArrayUniqueValues(int[,,] arr3D)
{
    int[] uniqueArr = CreateUniqueArrayRndInt(arr3D);
    
    int count = 0;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = uniqueArr[count++];
            }
        }
    }

}

int[] CreateUniqueArrayRndInt(int[,,] arr3D)
{
    int size = arr3D.Length;
    int[] uniqueArr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        int temp = rnd.Next(10, 100);
        while (IsNumberRepeats(uniqueArr, temp))
        {
            temp = rnd.Next(10, 100);
        }
        uniqueArr[i] = temp;
    }
    return uniqueArr;
}

bool IsNumberRepeats(int[] uniqueArr, int num)
{
    for (int i = 0; i < uniqueArr.Length; i++)
    {
        if (uniqueArr[i] == num) return true;
    }
    return false;
}

void Print3DArray(int[,,] arr3D)
{
    Console.WriteLine();
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write("{0,12}", arr3D[i, j, k] + $" ({i},{j},{k})");
            }
        }
        Console.Write(" ]\n");
    }
}

void Output(int[,,] arr3D)
{
    if (arr3D.Length > 90)
    {
        Console.WriteLine("\nРазмер массива превышает возможное количество уникальных положительных двузначных чисел.");
    }
    else
    {
        FillArrayUniqueValues(arr3D);
        Print3DArray(arr3D);
    }
}

(int Rows, int Columns, int Depth) array3dParam = Array3DParam();
int[,,] array3D = CreateArray3D(array3dParam);
Output(array3D);