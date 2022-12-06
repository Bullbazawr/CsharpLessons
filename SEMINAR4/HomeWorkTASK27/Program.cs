//Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Метод проверки есть ли у цифр числа сумма
bool Validate(int number)
{
    if(number > 9 || number < -9)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//Метод подсчета ко-ва цифр в числе
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

//Программа которая суммирует все цифры в числе

int number = GetNumber("Введите число");
bool isCorrect = Validate(number);
int result = 0;
int number1 = number;
if (isCorrect == true)
{
  int count = CountNumbers(number);
  for (int i = 0; i < count; i++)
  {
    result = result + (number1 % 10);
    number1 = number1 / 10;
  }
  Console.WriteLine($"Сумма цифр числа {number} ={result} ");
}
else
{
    Console.WriteLine($"Сумма ={number} ");
}