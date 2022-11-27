Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int mod = number % 10;
    Console.WriteLine(mod);
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}