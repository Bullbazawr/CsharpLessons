// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetNumber("Введите число");
int number2 = GetNumber("Введите число");
void GetNumbersFromOneToN(int numberM, int numberN)
{
    if (numberN < numberM)
    {
        return;
    }
    GetNumbersFromOneToN(numberM, numberN - 1);
    Console.Write(numberN + " ");
}
GetNumbersFromOneToN(number1, number2);