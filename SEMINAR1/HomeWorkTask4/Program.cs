Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C:");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA & numberB == numberC) Console.WriteLine("Все числа равны и являются максимальным значением");

if (numberA > numberB)
    if (numberA > numberC) Console.WriteLine($"Max={numberA}");
    else if (numberA < numberC)
    {
        Console.WriteLine($"Max={numberC}");
    }
    else
    {
        Console.WriteLine($"{numberA} и {numberC} равны и являются максимальным значением");
    }
else if (numberA < numberB)
     if (numberB > numberC) Console.WriteLine($"Max={numberB}");
     else if (numberB < numberC)
     {
        Console.WriteLine ($"Max={numberC}");
     }
     else
     {
        Console.WriteLine($"{numberB} и {numberC} равны и являются максимальным значением");
     }
else if (numberA == numberB)
    if (numberA > numberC) Console.WriteLine($"{numberA} и {numberB} равны и являются максимальным значением");
    else
    {
        Console.WriteLine($"Max= {numberC} ");
    }