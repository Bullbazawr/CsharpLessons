Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int number2= Convert.ToInt32(Console.ReadLine());

if (number2 % number1 == 0)
   {
    Console.WriteLine($" {number2} кратно {number1} ");
   }
else
   {
    Console.WriteLine($"Не кратно! остаток = {number2 % number1} ");
   } 