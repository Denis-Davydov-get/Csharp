// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Логика вычисления координат двух точек и  расстояния между ними в 3D пространстве.
void distance(float x1, float y1, float z1, float x2,float y2, float z2)
{
    double TioremaPifagora = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
    Console.WriteLine("{0: 0.00}",TioremaPifagora);
    return;
}
//Конвертация текста в число и переобределение переменных.
int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
//Ввод - вывод
int x1 = GetNum("Введите значение x1:");
int y1 = GetNum("Введите значение y1:");
int z1 = GetNum("Введите значение z1:");
int x2 = GetNum("Введите значение x2:"); 
int y2 = GetNum("Введите значение y2:"); 
int z2 = GetNum("Введите значение z2:"); 
Console.Write("A(" + x1 + "," + y1 + "," + z1 + "); " + "B(" + x2 + "," + y2 + "," + z2 + ",) -> ");
distance(x1, y1, z1, x2, y2, z2);