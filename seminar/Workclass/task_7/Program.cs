// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
void Value(int quarter)
{
    if (quarter == 1) Console.WriteLine("x > 0 , y > 0");
    if (quarter == 2) Console.WriteLine("x < 0 , y > 0");
    if (quarter == 3) Console.WriteLine("x < 0 , y < 0");
    if (quarter == 4) Console.WriteLine("x > 0 , y < 0");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Ввод данных от пользователя x, y
int quarter = GetNum("Введите значение четверти:");

Console.Write("Вы находитесь в четверти: ");
//определить четверть
Value(quarter);
//вывод

