// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetNumber("число");
int number2 = GetNumber("возвести в степень");
int GetNumbersFromOneToN(int numberM, int count)
{
    if (count < 1)
    {
        return 1;
    }
    count--;
    numberM *= GetNumbersFromOneToN(numberM, count);
    return numberM;
}
int sum = GetNumbersFromOneToN(number1, number2);
Console.WriteLine(sum);