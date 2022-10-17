Console.WriteLine("Введите длину массива.");

int len = Convert.ToInt32(Console.ReadLine());

double[] array = new Double[len];

randomFilling(array);
arrayOutput(array);
Console.WriteLine("максимальное число в массиве " + foundMax(array));
Console.WriteLine("миниимальное число в массиве " + foundMin(array));
double count = foundMax(array) - foundMin(array);
Console.WriteLine("разница между максимальным и минимальным элементами массива " + count);


double foundMax(double[] array)
{
    double max = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double foundMin(double[] array)
{
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}


void randomFilling(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
}


void arrayOutput(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");
        
    }
    Console.WriteLine(" ");
}