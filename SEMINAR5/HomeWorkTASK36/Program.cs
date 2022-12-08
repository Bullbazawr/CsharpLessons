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

// метод сумирования чисел с нечетным индексем
int GetSumUnevenIndex(int[] array, int sum = 0)
{
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}




int size = GetNumber("Введите размер масива");
int leftRange = GetNumber("Введите минимально возможное число(включительно)");
int rightRange = GetNumber("Введите максимально возможное число(включительно)");
int[] massiv = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", massiv)}]");
int result = GetSumUnevenIndex(massiv);
Console.WriteLine($"Сумма значение с нечетным индексом ={result}");