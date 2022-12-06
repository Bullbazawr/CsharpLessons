// Метод определения имеет ли число больше одного знака
bool Validate(int number)
{
    if (number > 9 || number < -9)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Метод подсчета количиства знаков в числе

int CountNumbers(int number)
{
  int count = 1;
  while(number / 10 >= 1)
  {
    number = number / 10;
    count += 1;
  }
  return count; 
}


// Метод ввода числа

int GetNumber(string message)   
{
Console.WriteLine(message);
return  Convert.ToInt32(Console.ReadLine());
}

// Программа нахождения количества знаков в числе

int number = GetNumber("Введите число");
bool isCorrect = Validate(number);
if(isCorrect == true)
{
    int cifra = CountNumbers(number);
    Console.WriteLine($"Количество знаков в {number} ={cifra} ");
}
else
{
    Console.WriteLine($"Колчичество знаков в числе {number} = 1 ");
}