//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Ведите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе число ");
int number2 = int.Parse(Console.ReadLine());
int result = number1 * number1;
if(number2 == result) Console.WriteLine($"{number2} не является квадратом {number1}");
else Console.WriteLine($"{number2} является квадратом {number1}");