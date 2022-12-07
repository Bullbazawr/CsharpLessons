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

//Метод нахождения числа в промежутке
int NumberBetween(int[] arr, int max, int min, int count = 0)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max)
        {
            count += 1;
        }
    }
    return count;
}

int Size = GetNumber("Количество цифр");
int LeftRange = GetNumber("Введите минимальное число");
int RightRange = GetNumber("Введите максимальное число");

int[] array = GetRandomArray(Size, LeftRange, RightRange);
Console.WriteLine($"[{string.Join(", ", array)}]");

int beginGap = GetNumber("Введите начало промежутка");
int endGap = GetNumber("Введите конец промежутка");
int result = NumberBetween(array, endGap, beginGap);
Console.WriteLine($"Колчичество цифр попадающих в промежуток от {beginGap} до {endGap} = {result}");