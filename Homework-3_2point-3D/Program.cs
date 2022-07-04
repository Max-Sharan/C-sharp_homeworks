Console.Clear();

Console.WriteLine("Введите координаты первой точки A: ");
Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки B: ");
Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int x = (x2 - x1) * (x2 - x1);
int y = (y2 - y1) * (y2 - y1);
int z = (z2 - z1) * (z2 - z1);
double sqrt = Math.Sqrt(x + y + z);

Console.Write("Расстояние между точками A и B = " + sqrt);