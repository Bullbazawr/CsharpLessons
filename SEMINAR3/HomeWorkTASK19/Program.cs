Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 10000;
int last = number % 10;
if (number > 9999 && number < 100000)
{
    if (first == last)
    {
        int number1 = number / 10;
        int first2 = number / 1000;
        int first02 = first2 % 10;
        int last2 = number1 % 10;
        if (first02 == last2)
            Console.WriteLine($"Число {number} является палиндромом");
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }

}
else
{
    Console.WriteLine("Введите пятизначное число!");
}

//Пытался сделать вариант для любых чисел
//Console.WriteLine("Введите число");
//int number = Convert.ToInt32(Console.ReadLine());
//int count =1;
//while (number / 10 >= 1)
//{
//    int numberA = number / 10;
//    count ++ ;
//}
//В этом отрезке условно находим сколько знаков в введеном числе
//
//int numberB = Math.Pow (10,count); возводим 10 в степень count чтобы получить число
// на которое нужно будет делить number чтоб узнать первое число, но строка не работает
// говорит невозможно явно преоброзить в int.