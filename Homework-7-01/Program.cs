
int rowNum = InputInt("Введите количество строк: ");
int colNum = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[rowNum, colNum];

FillArray(numbers);
PrintArray(numbers); 

Console.Write("Введите подряд 2 числа, каждое не больше 9: ");
string? userText = Console.ReadLine();

string? text = String.Empty;
int[] nums = new int[userText.Length];

for (int i = 0; i < userText.Length; i++)
{
    text += userText[i];
    nums[i] = Convert.ToInt32(text);
    text = String.Empty;
}

if (nums[0] < numbers.GetLength(0) && nums[1] < numbers.GetLength(1))
{
    Console.WriteLine($"Элемент на позиции [{nums[0]},{nums[1]}] = {numbers[nums[0], nums[1]]}");
}
else
    Console.WriteLine($"Элемента на позиции [{nums[0]},{nums[1]}] в массиве нет!"); 



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
