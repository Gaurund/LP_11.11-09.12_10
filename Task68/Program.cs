// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

(int Number, int Argument) GetNumberArgument()
{
    int num = -1;
    int arg = -1;
    while (num < 0)
    {
        num = InputNumber("Введите число M: ");
        if (num < 0) ErrorNegativeNumber();
    }
    while (arg < 0)
    {
        arg = InputNumber("Введите аргумент N: ");
        if (arg < 0) ErrorNegativeNumber();
    }
    return (num, arg);
}

void ErrorNegativeNumber()
{
    Console.WriteLine("\nЗначение не может быть отрицательным. Повторите ввод.\n");
}

int AckermannFunc(int num, int arg)
{
    if (num == 0) return arg + 1;
    if (arg == 0) return AckermannFunc(num - 1, 1);
    return AckermannFunc(num - 1, AckermannFunc(num, arg - 1));
}

void Output()
{
    (int num, int arg) param = GetNumberArgument();
    int ackResult = AckermannFunc(param.num, param.arg);
    Console.WriteLine($"m = {param.num}, n = {param.arg} -> A(m,n) = {ackResult}");
}

Output();