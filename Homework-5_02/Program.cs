void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}
void PrintArray(int[] array)
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
void PrintSumNum(int[] array, int sum)
{
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
}

int num = InputInt();
int[] numbers = new int[num];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine();

PrintSumNum(numbers, 0);