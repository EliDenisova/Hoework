﻿Console.WriteLine("Введите позиции элемента в двумерном массиве.");

int rowI = Convert.ToInt32(Console.ReadLine());
int columnJ = Convert.ToInt32(Console.ReadLine());

int[,] array = new Int32[5, 5];

randomFilling(array, -10, 10);
arrayOutput(array);
foundElement(array, rowI, columnJ);

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void foundElement(int[,] arr, int rowI, int columnJ)
{
    if (rowI > arr.GetLength(0) - 1 || columnJ > arr.GetLength(1) - 1)
    {
        Console.WriteLine("нет такого элемента");
    }
    else
    {
        Console.WriteLine($"По заданным позициям находится элемент {arr[rowI, columnJ]}");
    }
}

void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
}