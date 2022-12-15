// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// медтод создания двумерного массива
int[,] GetMatrix(int rowsCounts, int columnsCount )
{
    int[,] matr = new int[rowsCounts, columnsCount];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
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


int rows = GetNumber("Введите число строк");
int coloumns = GetNumber("Введите число стольбцов");    
int[,] matix = GetMatrix(rows, coloumns);
PrintMatrix(matix);
