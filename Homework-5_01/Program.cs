void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
void PrintEvenNum(int[] array, int even)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even += 1;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве = {even}");
}

int InputInt()
{
  Console.Write("Введите количество элементов массива: ");
  return Convert.ToInt32(Console.ReadLine());
}

int num = InputInt();

int[] numbers = new int[num];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine();

PrintEvenNum(numbers, 0);

// int even = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         even += 1;
//     }
// }
// Console.WriteLine($"Количество чётных чисел в массиве = {even}");