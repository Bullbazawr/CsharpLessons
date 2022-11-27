Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i <= number; i += 1)
{
    Console.WriteLine(i + " ");
}