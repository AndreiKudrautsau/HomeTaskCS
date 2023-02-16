// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

// int result = (number/10) - (number / 100) * 10;
// Console.WriteLine($"В числе {number} вторая цифра => {result}");

int secondDigital = SecondDigital (number);
Console.WriteLine($"В числе {number} вторая цифра => {secondDigital}");

int SecondDigital (int num)
{
    int digitalSecond = (num/10) - (num / 100) * 10;
    return digitalSecond;
}
