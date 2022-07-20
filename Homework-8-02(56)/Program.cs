int numRows = RandomNumbers(3, 8);
int numCols = RandomNumbers(2, 6);

while (numCols == numRows)
{
    if (numCols == numRows)
    {
        numRows = RandomNumbers(3, 8);
        numCols = RandomNumbers(2, 6);
    }
}

int[,] numbers = new int[numRows, numCols];
FillArray(numbers);
PrintArray(numbers);

int minRow = MinSummRows(numbers);
Console.WriteLine($"Строка с наименьшей суммой элементов - это {minRow} строка");

int MinSummRows(int[,] matrix, int minRowIndex = 0)
{
    int min = SummInRow(matrix, 0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SummInRow(matrix, i) < min)
        {
            minRowIndex = i;
            min = SummInRow(matrix, i);
        }
    }
    return minRowIndex + 1;
}

int SummInRow(int[,] matrix, int i, int result = 0)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result += matrix[i, j];
    }
    return result;
}

int RandomNumbers(int min, int max)
{
    return new Random().Next(min, max);
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

void PrintArray(int[,] matrix)
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