// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 - Среда, 5 - Пятница

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

// Альтернативное решение через массив. 

string[] daysNames = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" }; 
if (day <= 7 && day >= 1)
{
    Console.WriteLine(daysNames[(day - 1)]);
}
else
{
    Console.WriteLine("Такого дня недели не бывает!");
}

// Решение рассматриваемое на уроке.

// if (day == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (day == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (day == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (day == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (day == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (day == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (day == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня недели не бывает!");
// }

