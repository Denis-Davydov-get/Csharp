// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
//Рекурсия
void Print(int num1, int num2)
{
    if(num1 == num2)
    {
        Console.WriteLine(num1);
        return;       
    }
    Console.WriteLine(num1 + ", ");
    Print(num1 + 1, num2);
}
int num1 = GetNum("Введите число 1: ");
int num2 = GetNum("Введите число 2: ");
Print(num1, num2);
