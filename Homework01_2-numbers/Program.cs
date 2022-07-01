// Console.Clear();
Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число сформируется компьютером");
int b = new Random().Next(-100000,100000);

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