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

int[] GetEvenIntegers(int[] Array)//метод нахождения четных чисел и создания нового массива из них
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
    System.Array.Resize(ref mass, j); // здесь пришлось компилятору указать явно пространство имен System, для класса Array,
    return mass;                      //  т.к. в коде методов и тела программы используется идентификатор Array, совпадающий с именем класса Array из пространства имен System.
}

void PrintArray(int[] Array)//метод печати массивов в консоль
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1) Console.Write(Array[i]);
        else Console.Write($"{Array[i]}, ");
    }
    Console.Write("]");
}

// Т Е Л О    П Р О Г Р А М М Ы
int[] Array = GetArray();
int[] Even = GetEvenIntegers(Array);

Console.Clear();
PrintArray(Array);
Console.Write(" -> ");
PrintArray(Even);
