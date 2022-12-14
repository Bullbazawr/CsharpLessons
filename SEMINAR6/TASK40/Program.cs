// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetNumber("Введите сторону A");
int numberB = GetNumber("Введите сторону B");
int numberC = GetNumber("Введите сторону C");
if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
{
    Console.WriteLine("может");
}
else
{
    Console.WriteLine("не может");
}