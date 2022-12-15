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

// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetNumber("Введите число строк");
int coloumns = GetNumber("Введите число стольбцов");
int lRange = GetNumber("Введите минимальное число");
int rRange = GetNumber("Введите максимальное число");
int[,] matix = GetMatrix(rows, coloumns, lRange, rRange);
PrintMatrix(matix);
