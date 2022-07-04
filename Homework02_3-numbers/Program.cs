Console.Clear();

Console.WriteLine("Вы доверяете компьютеру выбрать числа?");
Console.Write("Введите да или нет: ");
string userAnswer = Console.ReadLine();

int x = 0;
int y = 0;
int z = 0;

if(userAnswer.ToLower() == "да")
{
    x = new Random().Next(-1000,1000);
    y = new Random().Next(-1000,1000);
    z = new Random().Next(-1000,1000);
}
else 
{
    Console.Write("Введите первое число: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    z = Convert.ToInt32(Console.ReadLine());
}

int maxFrom(int x, int y, int z)
{
    int max = x;
    if(y > max)
    {
        max = y;
    } 
    if(z > max) 
    {
        max = z;
    }
    Console.WriteLine();
    Console.WriteLine("Среди чисел: " + x + ", " + y + " и " + z);
    Console.WriteLine("Максимальное число: " + max);
    return max;
}

maxFrom(x, y, z);