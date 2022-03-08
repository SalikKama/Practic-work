//Показать числа от -N до N
//Показать четные числа от 1 до N
void PrintNumb( int b )
{
    int i = -b;
    while ( i < b + 1 )
    {
        Console.Write( i + " " );
        i++;
    }
}
void PrintChet( int b )
{
    int i = 0;
    while ( i < b + 1)
    {
        if ( i % 2 == 0 )
        {
            Console.Write( i + " " );
        }
        i++;
    }
}

Console.WriteLine("Введите число от 0 до 10");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumb(n);
Console.WriteLine();
PrintChet(n);
