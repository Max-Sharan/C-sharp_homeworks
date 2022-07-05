Console.Clear();
Console.Write("Введите целое число Number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

int sum = number % 10;

if (number / 10 == 0)
{
    Console.WriteLine("Сумма цифр в вашем числе = " + sum);
}
else
{
    while (number / 10 != 0)
    {
        number /= 10;
        sum = sum + number % 10;
    }
    Console.WriteLine("Сумма цифр в вашем числе = " + sum);
}
