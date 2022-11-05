void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,100);
        index++;
    }

}

void PrintAray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(" "+col[position]);
        position++;
    }
}

int [] array = new int [10];

FillArray(array);
PrintAray(array);
