// Метод ввода числа

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

// Метод умножения значений массива первый на последний, второй на предпоследний и т.д
int size = GetNumber("Введите размер массива");
int leftRange = GetNumber("Введите минимальную цифру массива");
int rightRange = GetNumber("Введите максимальну цифру массива");
int[] arr = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int[] arr2 = new int[size/2];
for (int i = 0; i < arr.Length / 2; i++)
{
    arr2[i] = arr[i] * arr[arr.Length - 1-i];
}
Console.WriteLine($"[{string.Join(", ", arr2)}]");