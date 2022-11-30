Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int remainder7 = number % 7;
int remainder23 = number % 23;

if (remainder7 == 0 && remainder23 == 0)
    {
        Console.WriteLine("Верно");
    }
else
    {
        Console.WriteLine("Неверно");
    }    