// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

//Метод перемножения индексов одинаковых по размеру матриц
int[,] GetProductMatrix(int[,] matrix, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
    return matrix;
}

int rowsCounts = GetNumber("Введите количество строк");
int columnsCounts = GetNumber("Введите количество столбцов");
int[,] matrix1 = GetMatrix(rowsCounts, columnsCounts, 1, 99);
int[,] matrix2 = GetMatrix(rowsCounts, columnsCounts, 1, 99);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
GetProductMatrix(matrix1, matrix2);
PrintMatrix(matrix1);