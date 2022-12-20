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


//Метод подсчета суммы чисел в строке двумерного массива
int[] GetSumRows(int[,] matrix)
{
    int[] sumRowsArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumRowsArray[i] = sum;

    }
    return sumRowsArray;
}

// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//метода нахождения индекса минимального числа в массиве
int GetIndexMinNumber(int[] array)
{
    int minNumberIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minNumberIndex])
        {
            minNumberIndex = i;
        }
    }
    return minNumberIndex;
}

int rowsCounts = GetNumber("Введите количество строк и столбцов");
int columnsCount = rowsCounts;
int[,] originalMatrix = GetMatrix(rowsCounts, columnsCount, -10, 99);
PrintMatrix(originalMatrix);
Console.WriteLine();
int[] sumRows = GetSumRows(originalMatrix);
int minSumRows = GetIndexMinNumber(sumRows);
Console.WriteLine($"Наименьшая сумма на {minSumRows + 1} строке");