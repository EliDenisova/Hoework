Console.WriteLine("Введите длину массива.");

int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

randomFilling(array, 100, 1000);
arrayOutput(array);
int evenNumber = countingEvenNumbers(array);
Console.WriteLine(evenNumber);

void randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}

int countingEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        
    }

    return count;
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