// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//Запрос цифры от пользователя
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int num = GetNum("Введите число: ");
//Рекурсия
void Rec(int n)
{
    if(n == 0) return;
    Rec(n-1);
    Console.WriteLine($"{n} ");
}

Rec(num);

