// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberFirst = 1; 
Console.Write($"Чётные числа от {numberFirst} до {number}: ");
while (numberFirst <= number)
{
   if (numberFirst % 2 == 0)
    {
        Console.Write($"{numberFirst}, ");
    }
    numberFirst++;
}