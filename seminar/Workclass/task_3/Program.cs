//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

int rem = number1 % number2;
if(number1 % number2 == 0) Console.WriteLine($"Некратно, остаток {rem}");
else Console.WriteLine($"{number1}, кратно {number2}");

