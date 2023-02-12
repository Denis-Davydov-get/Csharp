// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//Запрос номера от пользователя
int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//вывод матрицы в консоль
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + ", ");
        }
        Console.WriteLine();
    }
}
void SearchNumber(int[,] matrix, int rows, int columns)
{
    if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1)) Console.WriteLine($"Ваше число: {matrix[rows, columns]} ");
    else Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");
}
int[,] array = new int[10, 10];
int rows = GetNumber("Введите индекс строки");
int columns = GetNumber("Введите индекс столбца");
ShowMatrix(array);
SearchNumber(array, rows, columns);