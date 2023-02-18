// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int numberDayWeek = Convert.ToInt32(Console.ReadLine());

string digitWeek = NumberDayWeek(numberDayWeek);
Console.WriteLine($"Является ли день недели под номером {numberDayWeek} выходным? Ответ => {digitWeek}");

string NumberDayWeek (int digit)
{
    if (digit >= 1 && 5 >= digit) return "нет";
    if (digit == 6 || digit == 7) return "да";
    return "Введен неверный номер дня недели";     
}