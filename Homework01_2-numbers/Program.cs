Console.Clear();

int a = new Random().Next(-1000,1000);
int b = new Random().Next(-1000,1000);

int max = a;
int min = b;

if(a < b) 
{
    max = b;
    min = a;
}
Console.WriteLine("Среди чисел: " + a + " и " + b);
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);