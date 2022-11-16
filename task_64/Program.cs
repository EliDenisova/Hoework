Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(number);


void printNaturalNumbers(int n) {

    if(n == 1 ) {
        Console.Write(n);
    } else {
        Console.Write(n);
        printNaturalNumbers(n-1);
    }
}

