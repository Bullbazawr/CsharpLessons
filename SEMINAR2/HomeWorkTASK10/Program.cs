Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
    {
    int number1 = number / 10;
    int number2 = number1 % 10;
    Console.WriteLine($" {number2} ");
    }
else
    {
        Console.WriteLine("Введите трехзначное число!");
    }    