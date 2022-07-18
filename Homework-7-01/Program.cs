int rowNum = InputInt("Введите количество строк: ");
int colNum = InputInt("Введите количество столбцов: ");
double[,] numbers = new double[rowNum, colNum];

FillArray(numbers);
PrintArray(numbers); 


void PrintArray(double[,] array)
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

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(-10 + new Random().NextDouble() * 21, 1);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
