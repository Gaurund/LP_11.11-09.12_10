// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень его возводить: ");
int power = Convert.ToInt32(Console.ReadLine());

int Power(int num, int pow)
{
    if (pow == 0) return 1;
    if (pow % 2 == 0) return Power(num * num, pow / 2);
    return Power(num, pow - 1) * num;
}

int result = Power(number, power);
Console.WriteLine(result);