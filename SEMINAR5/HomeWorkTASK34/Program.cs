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

// метод нахождения четных чисел в массиве

int GetEvenNumbers(int[] arr, int count = 0)
{
    for (int i = 0; i < arr.Length; i ++)
    {
         if(arr[i] % 2 == 0)
         {
            count ++;
         }
    }return count;
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array =  GetRandomArray(20, 100, 999);
Console.WriteLine($"[{string.Join(", ", array)}]");
int result = GetEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {result} ");

// Есть еще такой вариант. Вроде симпотично выглядит :)
// метод ввода числа
// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int size = GetNumber("Введите размер масива");
// int leftRange = GetNumber("Введите минимально возможное число (включительно)");
// int rightRange = GetNumber("Введите максимально возможное число (включительно)");
// int[] massiv = GetRandomArray(size, leftRange, rightRange);
// Console.WriteLine($"[{string.Join(", ", massiv)}]");
// int result = GetEvenNumbers(massiv);
// Console.WriteLine($"Количество четных чисел в массиве = {result} ");