
string Resyrsiya(int start, int finish)
{
    if (start == finish) return start.ToString();
    return (start + ", " + Resyrsiya(start + 1, finish));
}


int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int start = GetNum("Введите число 1: ");
int finish = GetNum("Введите число 2: ");
Console.WriteLine(Resyrsiya(start, finish));