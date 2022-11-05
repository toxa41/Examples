Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());

void SumNumbers(int n)
{
    int a = 1;
    for (int i = 1; i <= n; i++) ;
    {
        a = a * i;
    }
    Console.WriteLine($"Произведение всех чисел от 1 до {n} равна {a}");

}
SumNumbers(n);