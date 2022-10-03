Console.WriteLine("Enter the number.");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
