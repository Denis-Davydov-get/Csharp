// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Resyrsiya(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Resyrsiya(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Resyrsiya(m - 1, Resyrsiya(m, n - 1));
    else return n + 1;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int m = GetNum("Введите число m: ");
int n = GetNum("Введите число n: ");
Console.WriteLine(Resyrsiya(m, n));