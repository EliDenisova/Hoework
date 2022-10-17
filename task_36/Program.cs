Console.WriteLine("Введите длину массива.");

int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

randomFilling(array, -100, 100);
arrayOutput(array);
int count = countingOddPosition(array);
Console.WriteLine(count);


int countingOddPosition(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }

    return count;
}


void randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}


void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");
        
    }
    Console.WriteLine(" ");
}