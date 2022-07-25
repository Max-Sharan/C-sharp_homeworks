int numRows = InputInt("Введите количество строк: ");
int numCols = InputInt("Введите количество столбцов: ");
int numDept = InputInt("Введите глубину массива: ");

int[] basic = new int[89];
FillBasicArray(basic);
ShuffleBasicArray(basic);
int[,,] numbers = new int[numDept, numRows, numCols];
FillArray(basic, numbers);
PrintArray(numbers);


int InputInt(string? msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintBasicArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i] + " ");
    }
}

void ShuffleBasicArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        int random = new Random().Next(0, matrix.Length);
        int buffer = matrix[random];
        matrix[random] = matrix[i];
        matrix[i] = buffer;
    }
}

void FillBasicArray(int[] matrix, int count = 10)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[i] = count;
        count++;
    }
}

void FillArray(int[] array, int[,,] matrix, int index = 0)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[index];
                index++;
            }
        }
    }
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}