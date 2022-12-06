//Проверка числа подходит ли оно под условие от 1 до A
bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;   
    }
}

// Метод нахождение сумы от 1 до A

int Sum1toA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += 1; 
    }
    return sum;
}


//Меттод ввода числа

int GetNumber(string message)   
{
Console.WriteLine(message);
return  Convert.ToInt32(Console.ReadLine());
}


// программа нахождения суммы чисел от 1 до number

int number = GetNumber("Введите число");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int suma1 = Sum1toA(number);
    Console.WriteLine($"Cумма чисел от 1 до {number} = {suma1}");
}
else
{
    Console.WriteLine($"Невозможно получить сумму от 1 до {number}");
}