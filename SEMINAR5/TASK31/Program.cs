// Метод создания случайного массива  указанием размера и промежутка от
// минимального значения и максимального значения
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


//метод сумирования всех положительных элементов массива и 
//всех отрицательных элементов массива отдельно
(int, int) GetSumPositiveAndNegative(int[] array)
{
    int sumpositive = 0;
    int sumnegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumpositive += array[i];
        }
        else
        {
            sumnegative += array[i];
        }
    }
    return (sumnegative, sumpositive);
}



//програма 

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] array = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
(int sumP, int sumN)= GetSumPositiveAndNegative(array);
Console.WriteLine($"Сумма положительных чисел ={sumP}, Сумма отрицательных чисел ={sumN}");