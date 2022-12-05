//AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Введите координату X первой точки");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
int yb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));

Console.WriteLine($"расстояние = {result:f2} ");