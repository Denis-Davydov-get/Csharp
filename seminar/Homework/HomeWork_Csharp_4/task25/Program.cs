//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//функция вычисления А и В
void GetSum(int num, int sqrt)
{
    int result = num;
    for (int i = 1; i < sqrt; i++)
    {
        result *= num;
    }
    Console.WriteLine(result);
}
//Ввод данных
int PromptNumder(string text) 
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Вывод
int num = PromptNumder("Введите число возводимое в степень: ");
int sqrt = PromptNumder("Введите число задающее степень: ");
GetSum(num, sqrt);

