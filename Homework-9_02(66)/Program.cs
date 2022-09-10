int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

int summ = 0;

Console.WriteLine(Summa(m, n));

int Summa(int m, int n)
{
    if (n == m)
        return n;
    else if (n < m)
        summ = n + Summa(m, n + 1);
    if (n > m)
        summ = m + Summa(m + 1, n);
    return summ;
}

int InputInt(string? msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}