// See https://aka.ms/new-console-template for more information

//Задача 32: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.WriteLine("Дан массив: {-4, -8, 8, 2}");
int [] array = {-4, -8, 8, 2};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(" "+ -array[i]);
}
