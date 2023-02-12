// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//Присваивание чисел через ввод
int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//присваивание для переменных
double b1 = GetNum("Введите b1 число: ");
double k1 = GetNum("Введите k1 число: ");
double b2 = GetNum("Введите b2 число: ");
double k2 = GetNum("Введите k2 число: ");
// найдёт точку пересечения двух прямых
void FindPoits(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else 
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
    }
}

//вывод
FindPoits(k1,b1,k2,b2);