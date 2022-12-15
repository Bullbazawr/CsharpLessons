// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int minNum = GetNumber("Введите минимально возможное число в массиве");
int maxNum = GetNumber("Введите максимально возможное число в массиве");
int[,] mat = GetMatrix(rows, columns, minNum, maxNum);
PrintMatrix(mat);
double[] array = new double[columns];
for (int j = 0; j < mat.GetLength(1); j++)
{
    double sum = 0;
    double count = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        sum = sum + mat[i, j];
        count += 1;
    }
    array[j] = sum / count;
}
Console.WriteLine($"[{string.Join("; ", array)}]");