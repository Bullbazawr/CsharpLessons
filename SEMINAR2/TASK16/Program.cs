Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int x = number1 * number1;
int y = number2 * number2;

if (number1 == y || number2 == x )
    {
        Console.WriteLine("Верно");
    }
else
    {
        Console.WriteLine("неверно");
    }    