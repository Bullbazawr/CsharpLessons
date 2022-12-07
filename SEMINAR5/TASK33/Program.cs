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

// Метод ввода числа

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//метод нахождения числа в масиве 
bool isIntNumberArray(int[] arr, int findNumber)
{
    bool result = false; //изначально думаем что числа нет в массиве
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            result = true;
        }
    }
    return result;
}

//Программа нахождения значения в массиве

int number = GetNumber("Введите число");
Console.WriteLine($"Ищем число {number} ");
const int SIZE = 12;
const int LEFTRANGE = -12;
const int RIGHTRANGE = 12;
int[] array = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
bool res = isIntNumberArray(array, number);
if (res == true)
{
    Console.WriteLine($"Число {number} есть в массиве ");
}
else
{
    Console.WriteLine($"Числа {number} нет в массиве ");
}