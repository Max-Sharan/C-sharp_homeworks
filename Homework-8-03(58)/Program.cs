int numRows = InputInt("Введите количество строк: ");
int numCols = InputInt("Введите количество столбцов: ");

int[,] numbersFirst = new int[numRows, numCols];
int[,] numbersSecond = new int[numRows, numCols];
FillArray(numbersFirst);
FillArray(numbersSecond);

PrintArray(numbersFirst);
Console.WriteLine();
PrintArray(numbersSecond);
Console.WriteLine();
int[,] numbers = FillArrayMultiply(numbersFirst, numbersSecond);
PrintArray(numbers);

int[,] FillArrayMultiply(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return matrix1;
}

int InputInt(string? msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}