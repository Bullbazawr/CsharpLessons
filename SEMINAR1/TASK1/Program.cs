﻿Console.WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1)
{
    Console.WriteLine("Ошибка! Введите число от 1 до 7");
}
if(number == 1) Console.WriteLine("Понедельник");
if(number == 2) Console.WriteLine("Вторник");
if(number == 3) Console.WriteLine("Среда");
if(number == 4) Console.WriteLine("Четверг");
if(number == 5) Console.WriteLine("Пятница");
if(number == 6) Console.WriteLine("Суббота");
if(number == 7) Console.WriteLine("Воскресенье");