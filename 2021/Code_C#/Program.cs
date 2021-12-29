int[] GetArray()
{
    Random r = new Random();
    int[] Array = new int[r.Next(10, 20)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = r.Next(-99, 100);
    }
    return Array;
}

(int[], int) GetEvenIntegers(int[] Array)
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
    return (mass, j);
}

void PrintArray(int[] Array, int arg)
{
    if (arg == 0) arg = Array.Length;
    for (int i=0; i<arg;i++)
        {
            Console.Write($"{Array[i]} ");
        }
    Console.WriteLine();       
}


int[] Array = GetArray();
(int[] Even, int evenNum) = GetEvenIntegers(Array);

Console.Clear();
PrintArray(Array, 0);
PrintArray(Even, evenNum);
