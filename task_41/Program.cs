//Console.WriteLine("Сколько чисел будете вводить от - бесконечности, до бесконечности?");

int number = 0;
while (true)
{
    number = Convert.ToInt32(Console.ReadLine());

    if (number > 0 && number <= 10)
    {
        Console.WriteLine("начинаем делать пальчиком тык)");
        int sum = getSum(number);
        Console.Write($"вы ввели {sum} чиселов (программист лентяй) больше нуля.");
        break;
    }
    else if (number <= 0)
    {
     Console.WriteLine("и как это сделать? Проще машину времени построить.");   
    }
    else if (number > 11 && number <= 99)
    {
        Console.WriteLine("ну такое, может меньше?");
    } 
    else if (number >= 100 && number <= 1000)
    {
        Console.WriteLine("долго делать пальчиком тык");
        continue;
    } 
    else if (number > 1000)
    {
        Console.WriteLine("неее, у меня столько времмени нет, да и лень. Давай поменьше.");
        continue;
    }
    else
    {
        Console.WriteLine(number);
    }
}

int getSum(int number)
{
    int i = 0;
    int count = 0;
    while ( i < number)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }

        i++;
    }

    return count;
}