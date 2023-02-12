//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите трехзначный номер ");
int num = Convert.ToInt32(Console.ReadLine()); // без ToInt32 у меня не работает
int num1 = num;
while(num1 > 999)
{
    num1 = num1 / 10;
}
int res = num1  % 10; // 1 правое число
if (num1 > 100) Console.WriteLine($"{num} -> {res}");
else Console.WriteLine($"{num} -> Третьей цифры нет");