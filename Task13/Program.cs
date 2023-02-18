// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) > 0 && Math.Abs(number) < 99) Console.WriteLine($"В числе {number} НЕТ третьей цифры");
if (Math.Abs(number) > 99 && Math.Abs(number) < 999) Console.WriteLine($"В числе {number} третья цифра => {number % 10}");
if (Math.Abs(number) > 999) Console.WriteLine($"В числе {number} третья цифра => {Division(number) % 10}");

int Division(int num)
{
    while (Math.Abs(num) > 999) num = num / 10;
    return num % 10;
}