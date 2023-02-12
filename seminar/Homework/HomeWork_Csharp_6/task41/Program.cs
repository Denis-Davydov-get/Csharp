// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//Присваивание чисел через ввод
// int GetNum(string text)
// {
//     Console.Write(text);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
//сколько чисел больше 0 ввёл пользователь
void PositivLenNumber()
{
    int count = 0;   
    //int[] array;
    Console.Write($"Введите размер списка: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        int currentNum = Convert.ToInt32(Console.ReadLine());
        // Console.Write(String.Join(", ", array[currentNum]));
        if (currentNum > 0)
            count++;
    }
    Console.Write($"Вы ввели чисел больше 0: {count}");
}
//вывод
PositivLenNumber();