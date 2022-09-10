int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

Console.WriteLine($"A({m},{n}) = {AckermannFunction(m, n)}");

int AckermannFunction (int m, int n)
{
    if (m == 0) 
        return n + 1;
    else
        if (m != 0 && n == 0) 
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

}

int InputInt(string? msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}