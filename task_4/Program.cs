Console.WriteLine("Enter the first number.");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number.");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine("maximum number " + firstNumber);
}
if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine("maximum number " + secondNumber);
}
if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine("maximum number " + thirdNumber);
}


