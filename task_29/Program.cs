// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите длину массива.");

int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

randomFilling(array, 0, 100);
arrayOutput(array);

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