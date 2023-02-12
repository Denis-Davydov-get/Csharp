// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
//будет находить произведение двух матриц
void Mult(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            result[i, j] = sum;
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//вывод
int[,] arr1 = new int[2, 2];
int[,] arr2 = new int[2, 2];
Console.WriteLine("первая матрица");
ShowMatrix(arr1);
Console.WriteLine("Вторая матрица");;
ShowMatrix(arr2);
Console.WriteLine("Вывод");
Mult(arr1, arr2);
