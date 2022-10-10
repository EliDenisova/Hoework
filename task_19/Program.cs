Console.WriteLine("Введите число.");

string number = Convert.ToString(Console.ReadLine());

for (int i = 0; i < number.Length/2; i++)
{
    if (number[i] != number[number.Length - 1 - i])
    {
        Console.WriteLine("Это не полиндром");
    }
    else
    {
        Console.WriteLine("Это полиндром");
    }
}