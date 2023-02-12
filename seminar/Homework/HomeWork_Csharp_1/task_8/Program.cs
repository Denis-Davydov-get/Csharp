//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number + " -> ");
while (1 < number)
{
    if (0 == number % 2)
    {
        Console.Write(number + ", ");
        number -= 2;
    }
    else if (0 != number % 2)
    {
        number--;
    }
}
