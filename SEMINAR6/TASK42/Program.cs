// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

// метод подсчета кол-цифр в числе когда переведем его в двоичный код
int GetDigitNumb(int numbeer)
{
    int i = 0;
    while (numbeer > 0)
    {
        numbeer = numbeer / 2;
        i++;
    }
    return i;
}


int number = GetNumber("Введите число");
int count = GetDigitNumb(number);
int[] arr2 = new int[count];
Console.WriteLine($"[{string.Join("", arr2)}]");
for (int i = 0; number > 0; i++)
{
    arr2[i] = number % 2;
    number = number / 2;
}
Console.WriteLine($"[{string.Join("", arr2)}]");
GetInversArray(arr2);
Console.WriteLine($"{string.Join("", arr2)}");