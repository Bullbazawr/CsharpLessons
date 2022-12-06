int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[8];
int number = GetNumber("Введите восьмизначное число");
if (number > 9999999 && number < 100000000)
{
    for (int i = 7; i > -1; i--)
    {
        array[i] = number % 10;
        number = number / 10;

    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
else
{
    Console.WriteLine ($"Число {number} не соответствует!");
}