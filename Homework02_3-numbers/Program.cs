Console.Clear();

int x = new Random().Next(-1000,1000);
int y = new Random().Next(-1000,1000);
int z = new Random().Next(-1000,1000);

int maxFrom(int x, int y, int z)
{
    int max = x;
    if(y > x) max = y;
    if(z > y) max = z;
    Console.WriteLine("Среди чисел: " + x + " " + y + " " + z);
    Console.WriteLine("Максимальное число: " + max);
    return max;
}

maxFrom(x, y, z);