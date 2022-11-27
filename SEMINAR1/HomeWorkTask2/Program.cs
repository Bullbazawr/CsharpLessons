Console.WriteLine("Ввелите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввелите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB) Console.WriteLine("Числа равны");

if (numberA > numberB) Console.WriteLine("A=Max, B=Min");

if (numberA < numberB) Console.WriteLine("B=Max, A=Min");