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
    GetNumbersFromOneToN(number - 1);
    Console.Write(number + " ");
}
GetNumbersFromOneToN(number);