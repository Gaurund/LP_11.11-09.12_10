// Задача 20. Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в плоскости.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int InputNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.WriteLine("Введите координаты точек.");

int x1 = InputNumber("X для первой точки: ");
int y1 = InputNumber("Y для первой точки: ");
int x2 = InputNumber("X для второй точки: ");
int y2 = InputNumber("Y для второй точки: ");

int MinusAndPow(int a, int b)
{
    return ((a - b) * (a - b));
}

double Distance(int x1c, int y1c, int x2c, int y2c)
{
    int xc = MinusAndPow(x1c, x2c);
    int yc = MinusAndPow(y1c, y2c);
    double dist = Math.Sqrt(xc + yc);
    dist = Math.Round(dist, 2, MidpointRounding.ToZero);
    return dist;
}

double distance = Distance(x1, y1, x2, y2);

Console.WriteLine($"Расстояние между точками: {distance}");