// Метод ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// y = k1 * x + b1, y = k2 * x + b2

float K1 = GetNumber("Введите k1 ");
float B1 = GetNumber("Введите b1");
float K2 = GetNumber("Введите k2");
float B2 = GetNumber("Введите b2");
float x = (B2 - B1) / (K1 - K2);
float y = K1 * x + B1;
if (K1 == K2)
{
    if (B1 == B2)
    {
        Console.WriteLine("прямые совпадают");
    }
    else
    {
       Console.WriteLine("прямые паралельны");
    }
}
Console.WriteLine($"{x} {y}");

