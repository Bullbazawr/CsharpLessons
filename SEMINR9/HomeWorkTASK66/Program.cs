// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetNumber("Введите число");
int number2 = GetNumber("Введите число");
int GetNumbersFromOneToN(int numberM, int numberN)
{
    int sum = 0;
    if (numberN == numberM)
    {
        return numberN;
    }
    sum = GetNumbersFromOneToN(numberM, numberN - 1) + numberN ;
    return sum;
}
int sum = GetNumbersFromOneToN(number1, number2);
Console.WriteLine(sum);