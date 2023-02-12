// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//Считывание текста и вывод в консоль
int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
//генерация массива c ограниченим по кол-ву
int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
//нахождение числа по модулю через цикл в массиве
int[] GetMinusArray(int[] array)
{
    int len = array.Length;
    int[] arrReturn = new int[len];
    for(int i = 0; i < len; i++)
    {
        arrReturn[i] = -array[i];
    }
    return arrReturn;
}
//Размер массива
int size = GetNum("Input size massive");
//Создание массива
int[] arr = GetArray(size, -100, 100);
//нахождение числа по модулю
int[] arrNew = GetMinusArray(arr);
//Вывод массива изначального
Console.WriteLine(String.Join(", ", arr));
//Вывод массива по модулю
Console.WriteLine(String.Join(", ", arrNew));
