// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначный номер ");
int num = Convert.ToInt32(Console.ReadLine()); // без ToInt32 у меня не работает
int numA = (num / 10) % 10; //находим десятки
if (num > 100 & num < 999) Console.WriteLine($"{num} -> {numA}");
else Console.WriteLine($"{num} -> Вы ввели не трехзначное число");
