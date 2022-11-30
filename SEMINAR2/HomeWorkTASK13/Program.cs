Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >99)
    {
     while (number > 999)
     {
       number = number / 10; 
     }
     number = number % 10; 
     Console.WriteLine($"{number}");
    }
else
    {
        Console.WriteLine("Число не имеет третьей цифры!");
    }    