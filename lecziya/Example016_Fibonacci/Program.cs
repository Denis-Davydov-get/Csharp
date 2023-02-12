double Factorial(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Factorial(n - 1) + Factorial(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");

}
