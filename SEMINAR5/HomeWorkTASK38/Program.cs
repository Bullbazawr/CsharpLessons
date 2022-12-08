// метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// // Метод создания случайного массива  указанием размера и промежутка от
// // минимального значения и максимального значения
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

// Метод нахожениея максимального значения в массиве
int GetMaxNumber(int[]array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }return max;
}

// Метод нахожениея минимального  значения в массиве
int GetMinNumber(int[]array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }return min;
}

int size = GetNumber("Введите размер массива");
int leftRange = GetNumber("Введите минимально возможное число");
int rightRange = GetNumber("Введите максимально возможное число");
int[] array = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", array)}]");
int max = GetMaxNumber(array);
int min = GetMinNumber(array);
int result = max - min;
Console.WriteLine($"Разница между наибольшим и наименьшим числом массива ={result} ");