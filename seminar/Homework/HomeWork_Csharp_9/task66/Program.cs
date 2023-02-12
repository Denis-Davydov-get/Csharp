// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Resyrsiya(int numberM, int numberN)
{
    if (numberM == 0) return (numberN * (numberN + 1)) / 2;            
    else if (numberN == 0) return (numberM * (numberM + 1)) / 2;       
    else if (numberM == numberN) return numberM;                       
    else if (numberM < numberN) return numberN + Resyrsiya(numberM, numberN - 1); 
    else return numberN + Resyrsiya(numberM, numberN + 1);            
    
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int numberM = GetNum("Введите число M: ");
int numberN = GetNum("Введите число N: ");
Console.WriteLine(Resyrsiya(numberM, numberN));