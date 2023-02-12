// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//генерация случайных чисел в массиве
void ShowMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[row, columns] = new Random().Next(0, 10);
            Console.Write($"{matrix[row, columns]} ");
        }
        Console.WriteLine();
    }
}
//находит строку с наименьшей суммой элементов
void SearchMinMatrixLines(int[,] matrix)
{
    int index = 0, minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + " ";
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index + 1}. ");
}
int[,] matrix = new int[5, 3];
ShowMatrix(matrix);
SearchMinMatrixLines(matrix);