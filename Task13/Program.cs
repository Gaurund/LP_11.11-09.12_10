// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputNumber()
{
    Console.Write("Введите целое положительное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int DecreaseToThreeDigits(int num)
{
    num = Math.Abs(num);
    for (; num > 1000; num /= 10); 

    return num;
}

string Check(int num)
{
    if (Math.Abs(num) > 99)
    {
        int third = (DecreaseToThreeDigits(num) % 10);
        return $"{num} -> {third}";
    }
    return $"{num} -> третьей цифры нет";
}


int number = InputNumber();


Console.WriteLine(Check(number));