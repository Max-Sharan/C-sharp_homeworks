
int InputInt(string? msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int numRows = InputInt("Введите количество строк: ");
int numCols = InputInt("Введите количество столбцов: ");

int[,] numbers = new int[numRows, numCols];
FillArray(numbers, 1);
PrintArray(numbers);
void FillArray(int[,] matrix, int k, int i = 0, int j = 0)
{
    matrix[i, j] = 1;
    for (j = 0; j < matrix.GetLength(1) - k; j++)
    {
        matrix[i, j + 1] = matrix[i, j] + 1;
    }
    for (i = 0; i < matrix.GetLength(0) - k; i++)
    {
        matrix[i + 1, j] = matrix[i, j] + 1;
    }
    for (j = matrix.GetLength(1) - k; j > 0; j--)
    {
        matrix[i, j - 1] = matrix[i, j] + 1;
    }
    for (i = matrix.GetLength(0) - k; i > k; i--)
    {
        matrix[i - 1, j] = matrix[i, j] + 1;
    }
    k++;
    for (j = 0; j < matrix.GetLength(1) - k; j++)
    {
        matrix[i, j + 1] = matrix[i, j] + 1;
    }
    for (i = k - 1; i < matrix.GetLength(0) - k; i++)
    {
        matrix[i + 1, j] = matrix[i, j] + 1;
    }
    for (j = matrix.GetLength(1) - k; j > k - 1; j--)
    {
        matrix[i, j - 1] = matrix[i, j] + 1;
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
