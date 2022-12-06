// метод определения, что числы не равны 0
bool Validate(int number1, int number2)
{
    if (number1 != 0 && number2 != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// метод возведениея числа A в степень B путем умножения числа A само на себя B раз

int ResNumbers(int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

// Метод ввода числа

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// программа возведения чисал A в степень B

int numberA = GetNumber("Введите число А");
int numberB = GetNumber("Введите число B");
bool isCorrect = Validate(numberA, numberB);
if (isCorrect == true)
{
    int result = ResNumbers(numberA, numberB);
    Console.WriteLine($"{numberA} в степени {numberB} = {result}");
}
else
{
    Console.WriteLine("Ошибка");
}