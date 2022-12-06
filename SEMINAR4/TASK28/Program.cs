// метод определения число больше 0
bool Validate(int number1)
{
    if (number1 != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метод ввода числа

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Метод умножения чисел от 1 до A
int ProductNumbers(int A)
{
    int sum = 1;
    for (int i = 1; i <= A; i++)
    {
        sum = sum * i;
    }
    return sum;
}

//программа умножения чисел от 1 до A

int number = GetNumber("Введите число:");
bool correct = Validate(number);
if (correct == true)
{
    int result = ProductNumbers(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {result} ");
}
else
{
    Console.WriteLine($"Произведение = 0");
}