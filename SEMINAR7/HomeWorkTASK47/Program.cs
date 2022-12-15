// Метод создания массива с рандомными дробными числами
double[,] GetMatrix(int rowsCounts, int columnsCount)
{
    double[,] matr = new double[rowsCounts, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble() * 10;
        }
    }
    return matr;
}

//Метод принта двумерного массива с дробными числами (показывает 2 знака после запятой)
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i, j]:f2}" + " ");
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
double[,] matix = GetMatrix(rows, coloumns);
PrintMatrix(matix);