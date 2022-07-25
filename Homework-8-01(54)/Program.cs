int numRows = InputInt("Введите количество строк: ");
int numCols = InputInt("Введите количество столбцов: ");

int[,] numbers = new int[numRows, numCols];
FillArray(numbers);
PrintArray(numbers);

Console.WriteLine();
FormatArrayByRows(numbers);
PrintArray(numbers);

void FormatArrayByRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        FormatArrayInRow(matrix, i);
    }
}
void FormatArrayInRow(int[,] matrix, int i)
{
    for (int x = 0; x < matrix.GetLength(1) - 1; x++)
    {
        ChangeFirstToMin(matrix, i, x);
    }
}

void ChangeFirstToMin(int[,] matrix, int i, int x, int currentIndex = 0)
{
    int min = matrix[i, x];
    for (int j = x; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            currentIndex = j;
            matrix[i, currentIndex] = matrix[i, x];
            matrix[i, x] = min;
        }
    }
}

int InputInt(string? msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
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