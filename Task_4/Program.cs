void Square( int c, int d)
{
    if ( c*c == d)
    {
        Console.WriteLine($"{d} является квадратом {c}");
    }
    else if ( d*d == c )
    {
        Console.WriteLine($"{c} является квадратом {d}");
    }
    else Console.WriteLine($"Не являются");
}

Console.WriteLine("Введите два числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Square( a, b);