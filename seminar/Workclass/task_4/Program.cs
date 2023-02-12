//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int result1 = number % 7;
int result2 = number % 23;
if(result1 == 0 & result2 == 0) Console.WriteLine($"{number} -> Yes");
else Console.WriteLine($"{number} -> No");

