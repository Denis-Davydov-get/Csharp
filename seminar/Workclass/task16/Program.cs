// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//генерация массива
int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
int[] array = GetArray(123, 0, 999);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] <= 99 & array[i] >= 10) count++;
}

Console.Write(String.Join(", ", array));
Console.WriteLine(count);


//