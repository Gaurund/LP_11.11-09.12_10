// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("Кратно!");
// }
// else
// {
//     Console.WriteLine("Не кратно, остаток =" + (firstNumber % secondNumber));
// }

// bool Multiplicity(int num1, int num2)
// {
//     return num1 % num2 == 0;
// }

// bool result = Multiplicity(firstNumber, secondNumber);
// Console.WriteLine(result ? "Кратно" : $"Не кратно, остаток = {firstNumber % secondNumber}");

int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}


int result = Multiplicity(firstNumber, secondNumber);
Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток = {result}");