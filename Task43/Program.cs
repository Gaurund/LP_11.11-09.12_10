// Задача 43: Напишите программу,
//  которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int B1, int K1, int B2, int K2) GetNumbers()
{
    int b1 = InputNumber("Введите число b1: ");
    int k1 = InputNumber("Введите число k1: ");
    int b2 = InputNumber("Введите число b2: ");
    int k2 = InputNumber("Введите число k2: ");
    return (b1, k1, b2, k2);
}

bool CheckParallel(int b1, int k1, int b2, int k2)
{
    return (k1 == k2 && b1 != b2);
}

bool CheckEqual(int b1, int k1, int b2, int k2)
{
    return (k1 == k2 && b1 == b2);
}

(double X, double Y) GetCoordinates(int intb1, int intk1, int intb2, int intk2)
{
    double b1 = Convert.ToDouble(intb1);
    double k1 = Convert.ToDouble(intk1);
    double b2 = Convert.ToDouble(intb2);
    double k2 = Convert.ToDouble(intk2);
    double y = (b2 * k1 - k2 * b1) / (k1 - k2);
    double x = (y - b1)/k1;
    return (x, y);
}

void Output((int b1, int k1, int b2, int k2) num)
{
    if (CheckParallel(num.b1, num.k1, num.b2, num.k2)) Console.WriteLine("\nПрямые параллельны.");
    else if (CheckEqual(num.b1, num.k1, num.b2, num.k2)) Console.WriteLine("\nПрямые совпадают полностью.");
    else
    {
        (double x, double y) getXY = GetCoordinates(num.b1, num.k1, num.b2, num.k2);
        Console.WriteLine($"\nТочка пересечения прямых: ({getXY.x}, {getXY.y})");
    }
}

(int numB1, int numK1, int numB2, int numK2) numbers = GetNumbers();

Output(numbers);