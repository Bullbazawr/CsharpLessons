// не уверен правильно ли я понял задчу, вроде так :)
int count = 0;
string stopword = "stop";
string str;
do
{
    Console.WriteLine("Введите число");
    str = Console.ReadLine();
    str = str.ToLower();
    bool res = int.TryParse(str, out int result);
    if (res == true)
    {
        if (result > 0)
        {
            count += 1;
        }
    }
} while (str != stopword);
Console.WriteLine($"вы ввели чисела больше 0, {count} раз");

