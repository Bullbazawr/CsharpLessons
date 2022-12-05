Console.WriteLine("Ввседите кординат X первой точки");
int XA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввседите кординат Y первой точки");
int YA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввседите кординат Z первой точки");
int ZA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввседите кординат X второй точки");
int XB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввседите кординат Y второй точки");
int YB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввседите кординат Z второй точки");
int ZB = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt((XA - XB) * (XA - XB) + (YA - YB) * (YA - YB) + (ZA - ZB) * (ZA - ZB));

Console.WriteLine($"Расстояние = {res:f2} ");