Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for (int x = 1; x <= number; x += 1)
    if ((x % 2) == 0)
{
    Console.WriteLine(x + " ");
}