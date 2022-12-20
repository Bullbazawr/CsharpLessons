//Метод принта двумерного массива
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

int[,] GetMatrixWithSpiralFilling(int rowsCounts, int columnsCount, int leftRange, int rihgtRange)
{
    int[,] matrix = new int[rowsCounts, columnsCount];
    Random random = new Random();
    int i = 0;
    int j = 0;
    for (j = 0; j < 4; j++)
    {
        matrix[i, j] = random.Next(leftRange, rihgtRange);
    }
    for (i = 1; i < 4; i++)
    {
        matrix[i, 3] = random.Next(leftRange, rihgtRange);
    }
    for (j = 2; j >= 0; j--)
    {
        matrix[3, j] = random.Next(leftRange, rihgtRange);
    }
    for (i = 2; i > 0; i--)
    {
        matrix[i, 0] = random.Next(leftRange, rihgtRange);
    }
    for ( j = 1; j < 3; j++)
    {
        matrix[1, j] = random.Next(leftRange, rihgtRange);
    }
     for ( j = 2; j > 0; j--)
    {
        matrix[2, j] = random.Next(leftRange, rihgtRange);
    }
    return matrix;
}

int[,] matrix = GetMatrixWithSpiralFilling(4, 4, 1, 9);
PrintMatrix(matrix);

//Ужасное решение конечно :D, не было времени подумать над этой задачей