//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
int numA = num / 100;
int numB = num % 10;
Console.WriteLine(num);
Console.WriteLine($"Без второго числа {numA}{numB}");
