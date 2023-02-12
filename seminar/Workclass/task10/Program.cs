// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int TextNumder(string text) //считывает text и записывает его в number
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int LenNumber(int number)
{
    int count = 0; // счетчик
    while (count != 0) // пока счетчик не дойдет до 0
    {
        number /= 10; // убираем 1 число справа
        count++; // записыаем в счетчик сколько получилось убрать справа число
    }
    return count;
}

int textNumber = TextNumder("Введите число: "); //просит ввести номер и записывает его в text
int result = LenNumber(textNumber); // вывод то что напечатали
Console.WriteLine(result);

