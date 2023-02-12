// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Функция подсчета цифр в числе
int NumberLen(int lenCount)
{
    int index = 0;
    while (lenCount > 0)
    {
        lenCount /= 10;
        index++;
    }
    return index;
}
// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    while (n > 0)
    {
    sum += n %10;
    n /= 10;
    }
    Console.Write(sum);
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Вывод
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
Console.Write(number + " -> " );
SumNumbers(number, len);