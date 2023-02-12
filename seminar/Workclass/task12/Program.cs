// Решение в группах задач:
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GetRandomArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i]+" ");
    }
}


int[] arr = GetRandomArray(8);
PrintArray(arr);
