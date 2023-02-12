// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int GetNum(string text)
{
    Console.Write(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}
int[,] GenerateMatrix(int rows, int columns, int lowerBount, int upperBound)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(lowerBount, upperBound + 1);
        }
    }
    return result;
}
void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + ", ");
        }
        Console.WriteLine();
    }
}
//Получение размерности двумерного массива о пользователя
//Генерация двумерного массива рзмерности m,n

int m = GetNum("Ввелите кол-во строк: ");
int n = GetNum("Ввелите кол-во столбцов: ");
int[,] matrix = GenerateMatrix(m, n, -100, 100);
ShowMatrix(matrix);
