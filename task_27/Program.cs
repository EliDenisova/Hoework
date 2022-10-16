
Console.WriteLine("Введите число.");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма чисел числа {number}, будет {addition(number)}");

int addition(int number)
{
    int count = 0;
    while (number > 0)
    {
        count += number % 10;
        number /= 10;
    }

    return count;
}