// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Resyrsiya(int numA, int numB)
{
    if (numB == 1) return numA;
    return numA * Resyrsiya(numA, numB -1);
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int numA = GetNum("Введите число: ");
int numB = GetNum("В каую степерь возвести?: ");
Console.WriteLine($"{numA} в {numB} степени = {Resyrsiya(numA, numB)}");