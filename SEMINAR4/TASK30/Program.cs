﻿// Создание массива и печать его
// int [] array = new int [8];
// Console.WriteLine($"[{string.Join(", ", array)}]");

int [] array = new int [8];
for (int i = 0; i < 8; i++)
{
     array[i]  = new Random().Next(0, 2);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
