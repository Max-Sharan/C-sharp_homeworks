void FillArray(int[,] matrix, int k = 1, int i = 0, int j = 0, int count = 1)
{
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        for (j = k - 1; j < matrix.GetLength(1) - k; j++)
        {
            if (matrix[i, j] == 0)
                matrix[i, j] = count++;
        }
        for (i = k - 1; i < matrix.GetLength(0) - k; i++)
        {
            if (matrix[i, j] == 0)
                matrix[i, j] = count++;
        }
        for (j = matrix.GetLength(1) - k; j > k - 1; j--)
        {
            if (matrix[i, j] == 0)
                matrix[i, j] = count++;
        }
        for (i = matrix.GetLength(0) - k; i > k; i--)
        {
            if (matrix[i, j] == 0)
                matrix[i, j] = count++;
        }
        if (matrix[i, j] == 0)
            matrix[i, j] = count++;
        k++;
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
