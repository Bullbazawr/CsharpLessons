// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число");
void GetNumbersFromOneToN(int number)
{
    if (number == 0)
    {
        return;
    }
    Console.Write(number + " ");
    GetNumbersFromOneToN(number - 1);
}
GetNumbersFromOneToN(number);