int rowNum = InputInt("Введите количество строк: ");
int colNum = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[rowNum, colNum];

FillArray(numbers);
PrintMatrix(numbers);

double[] aver = new double[colNum];
Console.Write("Среднее арифметическое каждого столбца: ");
Average(aver, numbers);

void Average(double[] array, int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        array[j] = Math.Round(sum / matrix.GetLength(0), 1);
        Console.Write(array[j] + " ");
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}