Console.Clear();
Console.Write("Введите положительное целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите положительное целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int aDegreeB = a;

for (int count = 1; count < b; count++)
{
    aDegreeB *= a;
}
Console.WriteLine("Ура! Мы возвели число A = " + a + ", в степень B = " + b + " и получилось: " + aDegreeB);