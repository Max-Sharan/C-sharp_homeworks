int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");
Console.WriteLine(Progression(m, n));

int Progression(int m, int n)
{
    if (n == m)
        return m;
    else if (n < m)
        Console.Write(Progression(m, n + 1) + ", ");
    if (n > m)
        Console.Write(Progression(m, n - 1) + ", ");
    return n;
}
int InputInt(string? msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}