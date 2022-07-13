void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1, 100)) / 10;
    }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
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