//Функция Аккермана
uint AckermanFunction(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return AckermanFunction(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    else
    {
        return AckermanFunction(m, n);
    }
}

Console.WriteLine($"A(0,1) = {AckermanFunction(0, 1)}");
Console.WriteLine($"A(1,2) = {AckermanFunction(1, 2)}");
Console.WriteLine($"A(2,3) = {AckermanFunction(2, 3)}");
Console.WriteLine($"A(3,4) = {AckermanFunction(3, 4)}");