// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A[i,j] = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int GetNum(string text)
{
    Console.WriteLine(text);
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
            result[i,j] = i + j;
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
            Console.Write(matrix[i, j] + "\t");
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
