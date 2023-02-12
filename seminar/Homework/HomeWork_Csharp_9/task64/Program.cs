// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
//Рекурсия
void Print(int n)
{
    if(n == 1)
    {
        Console.WriteLine(n);
        return;       
    }
    Console.Write(n + ", ");
    Print(n - 1);
}
int n = GetNum("Введите число: ");
Print(n);