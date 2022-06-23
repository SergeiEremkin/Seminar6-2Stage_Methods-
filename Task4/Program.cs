void Fib(int n)
{
    int a = 1;
    int b = 1;
    
    for (int i = 2; i < n; i++)
    {
        b = a + b;
        a = b - a;

        Console.Write($"{b} ");

    }
}

Fib(4);


