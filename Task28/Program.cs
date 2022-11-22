// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int InputNumber()
{
    Console.Write("Введите целое положительное число: ");
    // int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int MultDigits(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}

int number = InputNumber();

if (number > 0)
{
    int multDigits = MultDigits(number);
    Console.WriteLine($"{number} -> {multDigits}");
}
else
{
    Console.WriteLine("Требуется ввести натуральное число.");
}