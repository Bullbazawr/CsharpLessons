Console.WriteLine("Введите число X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Ответ 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Ответ 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Ответ 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Ответ 4");
}
else
{
    Console.WriteLine("Невозможно определить");
}