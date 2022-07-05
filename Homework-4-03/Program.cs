Console.Clear();
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n = -n;

void PrintArray(int[] array)
{
    int length = array.Length;
    Console.WriteLine("Введите элементы массива: ");
    int index = 0;

    for (index = 0; index < length; index++)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Сгенерированный массив:");
    Console.Write("[");
    for (index = 0; index < length - 1; index++)
    {
        Console.Write(array[index] + ", ");
    }
    Console.Write(array[index] + "]");
}

int[] mass = new int[n];
PrintArray(mass);