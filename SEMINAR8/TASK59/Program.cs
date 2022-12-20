// медтод создания двумерного массива и заполнения рандомнами числами
int[,] GetMatrix(int rowsCounts, int columnsCount, int leftRange, int rihgtRange)
{
    int[,] matr = new int[rowsCounts, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rihgtRange);
        }
    }
    return matr;
}

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

// Метод нахождения минимального числа в двумерном массиве
int GetMinNumber(int[,] matrix)
{
    int minNumber = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minNumber)
            {
                minNumber = matrix[i, j];
            }
        }
    }
    return minNumber;
}

//Метод нахождения индексов минимального числа
int[] GetMinNumberIndex(int[,] matrix, int minNumber)
{
    int[] array = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == minNumber)
            {
                array[0] = i;
                array[1] = j;
            }
        }

    }
    return array;
}




int[,] originalMatrix = GetMatrix(4, 4, 10, 99);
PrintMatrix(originalMatrix);
Console.WriteLine();
int minNumber = GetMinNumber(originalMatrix);
Console.WriteLine($"Мин число {minNumber}");
int[] minNumberIndex = GetMinNumberIndex(originalMatrix, minNumber);
Console.WriteLine($"{string.Join(",", minNumberIndex)}");
Console.WriteLine();
int[,] resulMatrix = new int[3, 3];
int k = 0;
int l = 0;
for (int i = 0; i < originalMatrix.GetLength(0); i++)
{
    if (i != minNumberIndex[0])
    {
        for (int j = 0; j < originalMatrix.GetLength(1); j++)
        {
            if (j != minNumberIndex[1])
            {
                resulMatrix[k, l] = originalMatrix[i, j];
                l++;
            }
        }
    }
    l=0;
    k++;
}
PrintMatrix(resulMatrix);