﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//генерация случайных чисел в массиве
void ShowMatrix(int[,] matrix)
{
    for (int columns = 0; columns < matrix.GetLength(0); columns++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[columns, i] = new Random().Next(0, 10);
            Console.Write($"{matrix[columns, i]} ");
        }
        Console.WriteLine();
    }
}
// Сортировка от большего к меньшему по строкам в массиве
void SortMatrixColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[j, k] < matrix[j, k + 1])
                {
                    int temp = matrix[j, k + 1];
                    matrix[j, k + 1] = matrix[j, k];
                    matrix[j, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}
//вывод массива с сортировкой
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 3];
ShowMatrix(matrix);
SortMatrixColumns(matrix);
PrintArray(matrix);

