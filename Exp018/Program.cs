int m = 3;
int n = 20;
int k = 1;
int q = 2;


int res = GetWays(m, n, k, q);

int GetWays(int m, int n, int k, int q)
{
    int resA = m;
    int count = 0;
    while (resA != n)
    {
        if ((resA * q) < n)
        {
            resA = resA * q;
        }
        else
        {
            resA = resA + k;
        }
    }
    count++;

    while (resA != n)
    {

        if ((resA * q) < n)
        {
            resA = resA + k;
        }
    }
    count++;
    while (resA != n)
    {
        while (resA < 3)
        {
            resA = resA + k;

        }
        if ((resA * q) < n)
        {
            resA = resA * q;
        }
        else
        {
            resA = resA + k;
        }
    }
    count++;
    return count;
}
Console.WriteLine("Количество возможных вариантов решения: "+res); // 3
