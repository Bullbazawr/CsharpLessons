Console.WriteLine("Введите первое число:");
string? answer1 = Console.ReadLine();
int number1 = Convert.ToInt32(answer1);

Console.WriteLine("Введите второе число:");
string? answer2 = Console.ReadLine();
int number2 = Convert.ToInt32(answer2);

if(number2 * number2 == number1)
{
    Console.WriteLine($"{number2} * {number2} = {number1}");
}
else
{
    Console.WriteLine("НЕ ТАК");
}