// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число");
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < array.Length; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}
Console.WriteLine($"[{string.Join("", array)}]");