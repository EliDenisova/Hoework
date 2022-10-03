Console.WriteLine("Enter the number.");

int number = Convert.ToInt32(Console.ReadLine());

if (number %2 == 0)
{
    Console.WriteLine("the number " + number + " is even");
} else Console.WriteLine("the number " + number + " is not even");