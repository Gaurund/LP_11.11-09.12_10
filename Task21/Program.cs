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

double Distance(int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
{
    int xSec = MinusAndPower(x_1, x_2);
    int ySec = MinusAndPower(y_1, y_2);
    int zSec = MinusAndPower(z_1, z_2);
    double dist = Math.Sqrt(xSec + ySec + zSec);
    dist = Math.Round(dist, 2, MidpointRounding.ToZero);
    return dist;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}), -> {distance}");