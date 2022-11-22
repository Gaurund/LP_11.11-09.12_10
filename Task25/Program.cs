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
    return pow > 0;
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

string Message()
{
    int num = InputNumber("Введите целое число: ");
    int pow = InputNumber("Введите натуральную степень в которую следует возвести: ");
    if (Check(pow))
    {
        int result = NumberToPower(num, pow);
        return $"{num}, {pow} -> {result}";
    }
    else
    {
        return "\nСтепень должна быть натуральным числом!";
    }

}

void Output()
{
    string message = Message();
    Console.WriteLine(message);
}

Output();