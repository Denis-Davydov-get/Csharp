// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// функция принимает число из скольки будет состоять массив
int[] GetRandomArray(int lenArray) 
{
    int[] array = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        array[i] = new Random().Next(lenArray);
    }
    return array;
}
// Функция ввода
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
}
//вывод
int[] arr = GetRandomArray(8);
PrintArray(arr);

