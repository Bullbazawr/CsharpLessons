// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод генерации случайных уникальных двухзначных чисел 
HashSet<int> numbers = new HashSet<int>();
Random rand = new Random();
int GetUniqueNumber()
{
    while (true)
    {
        int number = rand.Next(10, 99);
        if (!numbers.Contains(number))
        {
            numbers.Add(number);
            return number;
        }
    }
}

//Метод заполнения трехмаерного массива 
//с использованием генератора уникальных случайных двузначных чисел
int[,,] GetThreeDArray(int planeCount, int rowsCount, int columnsCount)
{
    int[,,] threeDArray = new int[planeCount, rowsCount, columnsCount];
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                threeDArray[i, j, k] = GetUniqueNumber();
            }
        }

    }
    return threeDArray;
}

//Метод принта трехмерного массива
void PrintThreeDArray(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        Console.WriteLine();
        Console.WriteLine("Плоскость:" + (i + 1));
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                Console.Write($"{threeDArray[i, j, k]}({i},{j},{k}) ");

            }
            Console.WriteLine();
        }
    }
}


int planeCount = GetNumber("Введите количество плоскастей");
int rowsCount = GetNumber("Введите количество строк");
int columnsCount = GetNumber("Введите количество столбцов");
int numberOfElements = rowsCount * columnsCount * planeCount;
if ( numberOfElements > 90)
{
    Console.WriteLine("Не сущевствует достаточно уникальных значений!");
}
else
{
int[,,] threeDArray = GetThreeDArray(planeCount, rowsCount, columnsCount);
PrintThreeDArray(threeDArray);
}