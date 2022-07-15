Console.Write("Вводите любые целые числа подряд: ");
string? userText = Console.ReadLine();

string? buff = String.Empty;
int num = CountEmptyString(userText, 1);

int[] numbers = new int[num];
ConvertText(numbers, userText);
Console.Write("Введённые Вами числа: ");
PrintArray(numbers);
Console.WriteLine();
EvenNumbers(numbers, 0);

void EvenNumbers(int[] array, int even)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            even++;
    }
    Console.WriteLine($"Кол-во чисел > 0 = {even}");
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
}

void ConvertText(int[] array, string text)
{
    for (int i = 0, j = 0; j < text.Length; j++)
    {
        if (text[j] != ',' && text[j] != ' ' && text[j] != '.')
            buff += text[j];
        else if (buff != String.Empty)
        {
            array[i] = Convert.ToInt32(buff);
            buff = String.Empty;
            i++;
        }
        if (j == text.Length - 1)
            array[i] = Convert.ToInt32(buff);
    }
}
int CountEmptyString(string text, int count)
{
    for (int i = 0, j = 1; i < text.Length; i++)
    {
        if (text[i] != ',' && text[i] != ' ' && text[i] != '.')
            j++;
        else if (j > 0)
        {
            count++;
            j = 0;
        }
    }
    return count;
}