// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент в массиве
void GenerateMatrix(int[,] matrix)
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
int[] SortArray(int[,] matrix)
{
    int[] array = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[matrix[i, j]] += 1;
        }
        Console.WriteLine();
    }
    return array;
}
int[,] array = new int[10, 10];
void ShowArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int [,] matrix = new int[0, 10];
ShowArray(matrix);