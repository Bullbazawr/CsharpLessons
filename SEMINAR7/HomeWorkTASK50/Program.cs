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



int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int lRange = GetNumber("Введите минимальное число в массиве");
int rRange = GetNumber("Введите максимальное число в массиве");
int numRow = GetNumber("Введите номер строки");
int numCol = GetNumber("Введите номер столбца");
int[,] matix = GetMatrix(rows, columns, lRange, rRange);
bool res1 = numRow <= rows && numRow > 0;
bool res2 = numCol <= columns && numCol > 0;
if (res1 == true && res2 == true)
{
    int result = matix[numRow - 1, numCol - 1];
    PrintMatrix(matix);
    Console.WriteLine($"Искомое число {result}");
}
else
{
    Console.WriteLine("Введеные параметры выходят за предел массива");
}