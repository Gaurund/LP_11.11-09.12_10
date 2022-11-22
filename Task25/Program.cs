// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Check(int pow)
{
    return pow < 1;
}

int NumberToPower(int num, int pow)
{
    int result = 1;
    while (pow > 0)
    {
        result *= num;
        pow--;
    }
    return result;
}

void Output()
{
    int pow = -1;
    int num = InputNumber("Введите целое число: ");
    while (Check(pow))
    {
        pow = InputNumber("Введите степень в которую следует возвести: ");
        if (Check(pow))
        {
            Console.WriteLine("\nСтепень должна быть натуральным числом!\n");
        }
    }
    int result = NumberToPower(num, pow);
    Console.WriteLine($"{num}, {pow} -> {result}");
}

Output();