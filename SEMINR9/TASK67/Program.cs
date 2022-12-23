// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetNumber("Введите число");

int GetNumbersFromOneToN(int number)
{
    int sum = 0;
    if (number / 10 == 0)
    {
        return number;
    }
    sum = GetNumbersFromOneToN(number / 10) + number % 10;
    return sum;

}
int sum = GetNumbersFromOneToN(number1);
Console.WriteLine(sum);