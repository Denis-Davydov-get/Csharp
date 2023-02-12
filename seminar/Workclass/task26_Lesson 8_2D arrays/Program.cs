// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

void ArithmeticMeanColumns(int[,] arr)
{
  int len = arr.GetLength(0);
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    // int temp = arr[0, j];
    // arr[0, j] = arr[len - 1, j];
    // arr[len - 1, j] = temp;
    (arr[0,j], arr[len-1,j]) = (arr[len-1,j], arr[0,j]);
  }
}

void ShowArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int[,] GenerateArray(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(lowerBound, upperBound + 1);
    }
  }
  return array;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}
// получить значение от пользователя
int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
// генерация массива
int[,] array = GenerateArray(m, n, 0, 10);
ShowArray(array);
ArithmeticMeanColumns(array);
Console.WriteLine();
ShowArray(array);