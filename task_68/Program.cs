Console.WriteLine("Введите число число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число число N");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции {ackermannFunction(numberM, numberN)}");

int ackermannFunction(int m, int n) {

    if(m == 0) {
        return n + 1;
    }
    if(m > 0 && n == 0) {
        return ackermannFunction(m - 1, 1);
    }
    if(m > 0 && n > 0) {
       return ackermannFunction(m - 1, ackermannFunction(m, n - 1));
    }
    return ackermannFunction(m, n);
}