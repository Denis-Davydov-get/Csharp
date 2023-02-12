int[] array = { 11, 21, 31, 41, 5, 6, 17, 18, 19 };

int n = array.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}