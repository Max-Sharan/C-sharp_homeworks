int InputInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void CoordCrossPoint(int a, int b, int c, int d)
{
    if (a == c && b == d)
        Console.WriteLine("Прямые полностью совпадают");
    else if (b == d)
        Console.WriteLine("Прямые параллельны друг другу и никогда не пересекутся!");
    else
    {
        double y = Convert.ToDouble(a * d - c * b) / (d - b);
        double x = (y - a) / b;
        Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");
    }
}

int b1 = InputInt("Введите 1е число: ");
int k1 = InputInt("Введите 2е число: ");
int b2 = InputInt("Введите 3е число: ");
int k2 = InputInt("Введите 4е число: ");

CoordCrossPoint(b1, k1, b2, k2);

