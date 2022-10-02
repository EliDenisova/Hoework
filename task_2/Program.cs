
Console.WriteLine("Enter the first number.");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number.");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber) {
    Console.WriteLine("Pure " + firstNumber + " is greater than the number " + secondNumber);
} else Console.WriteLine("Pure " + secondNumber + " is greater than the number " + firstNumber);