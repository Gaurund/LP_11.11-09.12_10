// Задача 18. Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// string Range(int qrtr)
// {
//     if (qrtr == 1) return "x > 0 и y > 0";
//     if (qrtr == 2) return "x < 0 и y > 0";
//     if (qrtr == 3) return "x < 0 и y < 0";
//     if (qrtr == 4) return "x > 0 и y < 0";
//     return "Такой четверти нет!";
// }

// string result = Range(quarter);

// Console.WriteLine(result);

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string Range(string qrtr)
{
    if (qrtr == "1") return "x > 0 и y > 0";
    if (qrtr == "2") return "x < 0 и y > 0";
    if (qrtr == "3") return "x < 0 и y < 0";
    if (qrtr == "4") return "x > 0 и y < 0";
    return "Введены неверные данные.";
}

string result = Range(quarter);

Console.WriteLine(result);