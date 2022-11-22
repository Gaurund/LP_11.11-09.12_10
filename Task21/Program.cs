// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.WriteLine("Введите координаты точек.");

int x1 = InputNumber("X для первой точки: ");
int y1 = InputNumber("Y для первой точки: ");
int z1 = InputNumber("Z для первой точки: ");
int x2 = InputNumber("X для второй точки: ");
int y2 = InputNumber("Y для второй точки: ");
int z2 = InputNumber("Z для второй точки: ");

int MinusAndPower(int num1, int num2)
{
    return ((num1 - num2) * (num1 - num2)); 
}

double Distance(int xx1, int yy1, int zz1, int xx2, int yy2, int zz2)
{
    int xSec = MinusAndPower(xx1, xx2);
    int ySec = MinusAndPower(yy1, yy2);
    int zSec = MinusAndPower(zz1, zz2);
    double dist = Math.Sqrt(xSec + ySec + zSec);
    dist = Math.Round(dist, 2, MidpointRounding.ToZero);
    return dist;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}), -> {distance}");