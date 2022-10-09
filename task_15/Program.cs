
Console.WriteLine("Введите номер деня недели");

int weekDay = 0;
while (true)
{
    weekDay = Convert.ToInt32(Console.ReadLine());

    if (weekDay > 0 && weekDay <= 7)
    {
        break;
    }
    
    {
        Console.WriteLine("на нашей планете нет такиих дней недели.");
        Console.WriteLine("");
        Console.WriteLine("Повторите ввод");
    }
}

if (weekDay == 6 || weekDay == 7)
{
    Console.WriteLine("Надеваем мягкую пижамку и наливаем какао, ведь сегодня выходной!");
}
else Console.WriteLine("Снимаем пижамку, пьем кофе и идем на работу. Сегодня будний день.");