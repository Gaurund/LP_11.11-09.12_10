// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Пожалуйста, введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Output(int num)
{
    for (int count = 1; count <= num; count++)
    {
        int pow = count * count;
        Console.WriteLine($"{count} | {pow}");
    }
}

Output(number);