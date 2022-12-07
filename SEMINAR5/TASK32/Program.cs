// // Метод создания случайного массива  указанием размера и промежутка от
// // минимального значения и максимального значения
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

//программа замены знаков (+ на - и - на +)
const int SIZE = 12;
const int LEFTRANGE = -12;
const int RIGHTRANGE = 12;

int[] array = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}
Console.WriteLine($"[{string.Join(", ", array)}]");




