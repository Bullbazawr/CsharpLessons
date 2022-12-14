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

//метод разварота массива
void GetInversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int save = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = save;
    }
}


int[] array = GetRandomArray(10, 1, 20);
Console.WriteLine($"[{string.Join(", ", array)}]");
GetInversArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");