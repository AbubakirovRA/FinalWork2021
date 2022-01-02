int[] GetArray()// метод создания и заполнения массива
{
    Random r = new Random();
    int[] Array = new int[r.Next(10, 20)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = r.Next(-99, 100);
    }
    return Array;
}

(int[], int) GetEvenIntegers(int[] Array)//метод нахождения четных чисел и создания нового массива из них
{
    int[] mass = new int[Array.Length];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            mass[j] = Array[i];
            j++;
        }
    }
    //System.Array.Resize(ref mass, j); //возможен вариант изменения размера массива, в соответствии с количеством значимых элементов в нем;
    return (mass, j);
}

void PrintArray(int[] Array, int arg)//метод печати массивов в консоль
{
    Console.Write("[");
    if (arg == 0) arg = Array.Length;
    for (int i=0; i<arg;i++)
        {
            if (i==arg-1) Console.Write($"{Array[i]}");
            else Console.Write($"{Array[i]}, ");
        }
    Console.Write("]");     
}

// Т Е Л О    П Р О Г Р А М М Ы
int[] Array = GetArray();
(int[] Even, int evenNum) = GetEvenIntegers(Array);

Console.Clear();
PrintArray(Array, 0);
Console.Write(" -> ");
PrintArray(Even, evenNum);
