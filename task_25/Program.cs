
Console.WriteLine(exponentiation(2, 4));

int exponentiation(int naturalNumber, int degree)
{

    int count = naturalNumber;
    for (int i = 1; i < degree; i++)
    {
        count *= naturalNumber;
    }

    return count;
}