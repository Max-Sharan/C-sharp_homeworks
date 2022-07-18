void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(-10 + new Random().NextDouble() * 21, 1);
    }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
}
int InputInt()
{
    Console.Write("Введите количество элементов массива: ");
    return Convert.ToInt32(Console.ReadLine());
}
void MaxMin(double[] array, double max, double min)
{
    max = array[0];
    min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Максимальный элемент = {max}; минимальный элемент = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным = {max - min}");
}

int num = InputInt();
double[] numbers = new double[num];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine();

MaxMin(numbers, 0, 0);