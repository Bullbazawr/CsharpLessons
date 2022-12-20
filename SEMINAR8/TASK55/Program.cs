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
int rows1 = GetNumber("Введите количество строк");
int columns1 = GetNumber("Введите количество столбцов");
int[,] matrix1 = GetMatrix(rows1, columns1, 0, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int rows2 = columns1;
int columns2 = rows1;
int[,] matrix2 = new int[rows2, columns2];
if (rows1 <= 1 || columns1 <= 1)
{
    Console.WriteLine("Числа строк и столбцов должны быть больше единицы");
}
else
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix2[j, i] = matrix1[i, j];
        }
    }
}
PrintMatrix(matrix2);