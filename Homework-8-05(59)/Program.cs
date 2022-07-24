
int InputInt(string? msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int numRows = InputInt("Введите количество строк: ");
int numCols = InputInt("Введите количество столбцов: ");

int[,] numbers = new int[numRows, numCols];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

PrintNewArray(numbers);

void PrintNewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == FindMinimumRow(matrix))
            continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == FindMinimumCol(matrix))
                continue;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindMinimumRow(int[,] matrix, int currentRow = 0)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                currentRow = i;
            }
        }
    }
    return currentRow;
}
int FindMinimumCol(int[,] matrix, int currentCol = 0)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                currentCol = j;
            }
        }
    }
    return currentCol;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                Console.Write(matrix[i, j] + "  ");
            else
                Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}