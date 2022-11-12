// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число из трёх: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число из трёх: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число из трёх: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");

// Есть ещё читерский вариант через массив:

// int[] numbers = new int[3] ;
// string[] name = {"первое", "второе", "третье"};

// for (int i = 0; i < 3; i++)
// {
//     Console.Write($"Введите {name[i]} число из трёх: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// };

// Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]} -> {numbers.Max()}");