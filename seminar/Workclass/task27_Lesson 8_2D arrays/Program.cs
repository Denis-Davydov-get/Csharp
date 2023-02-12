// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray2D(int rows, int cols, int min, int max)
{
    int[,] arr = new int[rows,cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    return arr;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3} ",array[i, j]));
        }
        Console.WriteLine();
    }
}


int[,] Transp(int[,] array)
{
    int[,] arrayNew = new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           arrayNew[j,i] = array[i,j];
        }
    }
    return arrayNew;
}

int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

int[,] array = GetArray2D(sizeM, sizeN, -99, 100);

PrintArray2D(array);

int[,] arrayTransp= Transp(array);

PrintArray2D(arrayTransp);