

int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);
Console.WriteLine($"Ваше число {n}");

Console.WriteLine($"Треугольник Паскаля ");
pascalTriangle(n);

    void pascalTriangle(int n)
    {
        for (int line = 1; line <= n; line++)
        {
            for (int j = 0; j <= (n - line); j++)
                {
                    Console.Write(" "); 
                }
            int c = 1;
            for (int i = 1; i <= line; i++)
            {
                Console.Write(" ");
                Console.Write(c);
                c = c * (line - i) / i;
            }
            Console.WriteLine(" ");
        }
    }


