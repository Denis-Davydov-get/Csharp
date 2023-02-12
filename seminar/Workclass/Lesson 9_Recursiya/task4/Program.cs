// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Resyrsiya(int number)
{
    if (number <= 10) return number;
    return number % 10 + Resyrsiya(number / 10);
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int number = GetNum("Введите число больше 100: ");
Console.WriteLine(Resyrsiya(number));