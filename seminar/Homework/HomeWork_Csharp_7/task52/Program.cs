// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
void Average(int[,] matrix)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        double sum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            sum += matrix[rows, columns];
        }
        Console.Write(Math.Round(sum / matrix.GetLength(0), 2));
        if (columns != matrix.GetLength(1) - 1) Console.Write("; ");
    }
    Console.WriteLine(".");
}
int[,] array = new int[10, 10];
// GenerateMatrix(array);
ShowMatrix(array);
Console.Write("Среднее арифметическое каждого столбца: ");
Average(array);
