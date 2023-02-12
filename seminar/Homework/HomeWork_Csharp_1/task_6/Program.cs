//принимает число и выдаёт, является ли число чётным
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number % 2;
if (result == 0) Console.WriteLine(number + "-> Да");
else Console.WriteLine(number + "-> Нет");