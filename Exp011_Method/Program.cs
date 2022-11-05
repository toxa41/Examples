int[] array = { 1, 2, 31, 55, 43, 5, 6, 43 };

int n = array.Length;
int find = 43;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Инекс числа: {index}");
    }
        index++;
}