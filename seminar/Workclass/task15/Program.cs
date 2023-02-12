// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

//Считывание текста и вывод в консоль
int PromptNumder(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}
//генерация массива
int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
//Поиск числа в массиве
string FindNumber(int[] arr, int find)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == find)
        {
            return "Yes";
        }
    }
    return "No";
}
//Задаем переменные массива
int find = PromptNumder("Какое число нужно найти?:");
//Создаем массив
int[] massive = GetArray(12,-999, 999);
Console.Write(String.Join(", ", massive));
string findNumber = FindNumber(massive, find);
Console.WriteLine(findNumber);