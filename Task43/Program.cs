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

(int , int , int , int ) GetNumbers()
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

(double X, double Y) GetCoordinates(int intB1, int intK1, int intB2, int intK2)
{
    double b1 = Convert.ToDouble(intB1);
    double k1 = Convert.ToDouble(intK1);
    double b2 = Convert.ToDouble(intB2);
    double k2 = Convert.ToDouble(intK2);
    double y = (b2 * k1 - k2 * b1) / (k1 - k2);
    double x = (y - b1) / k1;
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

(int , int , int , int ) numbers = GetNumbers();

Output(numbers);