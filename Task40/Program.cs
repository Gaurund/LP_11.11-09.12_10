// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return num;
}

bool TriangleAvailable(int a, int b, int c)
{
    return (a < b + c) && (b < a + c) && (c < a + b);
}

int sideA = InputNumber("Введите длину первой стороны: ");
int sideB = InputNumber("Введите длину второй стороны: ");
int sideC = InputNumber("Введите длину третей стороны: ");

Console.WriteLine(TriangleAvailable(sideA, sideB, sideC) ? "Да" : "Нет");