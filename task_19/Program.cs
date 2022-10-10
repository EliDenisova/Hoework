Console.WriteLine("Введите число.");

string number = Convert.ToString(Console.ReadLine());

bool palindrom = true;
for (int i = 0; i < number.Length / 2; i++)
{
    if (number[i] != number[number.Length - 1 - i])
    {
        palindrom = false;
    }
}

if (palindrom)
{
    Console.WriteLine("Это палиндром");
}
else Console.WriteLine("Это не палиндром");