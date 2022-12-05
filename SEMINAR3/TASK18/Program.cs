Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Координаты по оси X и Y > 0 ");
}
else if (number == 2)
{
    Console.WriteLine("Координаты по оси X < 0 а Y > 0 ");
}
else if (number == 3)
{
    Console.WriteLine("Координаты по оси X < 0 а Y < 0 ");
}
else if (number == 4)
{
    Console.WriteLine("Координаты по оси X > 0 а Y < 0 ");
}
else
{
    Console.WriteLine(" Номер четверти от 1 до 4 ");
}
