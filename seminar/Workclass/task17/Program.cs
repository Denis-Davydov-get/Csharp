// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//генерация массива
int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int[] ArraySymPair(int[] array)
{
    int len = (array.Length + array.Length%2) / 2;
    int[] arrayResult = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrayResult[i] = array[i] * array[^(i + 1)];
    }
    if(array.Length  % 2 == 1)
    {
        arrayResult[^1] = array[len -1];
    }
    return arrayResult;
}
int[] array = GetArray(4, 1, 10);
Console.WriteLine(String.Join(", ", array));
int[] arrayResult = ArraySymPair(array);
Console.WriteLine(String.Join("\t", arrayResult));
