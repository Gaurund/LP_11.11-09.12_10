// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    // Console.Write($"{num} "); // Если вывод стоит до вызова рекурсии, то вывод стека не касается, соответственно всё идёт по прямой
    NaturalNumbers(num - 1);
    Console.Write($"{num} "); // Если вывод стоит после вызова рекурсии, то данный выходят из стека в обратном порядке First In Last Out
}

// -- Варианте без слова RETURN --

// void NaturalNumbers(int num)
// {
//     if (num > 0)
//     {
//         NaturalNumbers(num - 1);
//         Console.Write($"{num} ");
//     }
// }


NaturalNumbers(number);