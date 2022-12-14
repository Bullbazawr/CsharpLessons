int[] array = {1,2,3,4,5,6,7,8,9,10,};
Console.WriteLine($"[{string.Join("", array)}]");
int[] mass = new int [array.Length];
Console.WriteLine($"[{string.Join("", mass)}]");
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = array[i];
}
Console.WriteLine($"[{string.Join("", array)}]");
Console.WriteLine($"[{string.Join(" ", mass)}]");