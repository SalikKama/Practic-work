//Показать четные числа от 1 до N
void Weekend( string[] collect, int a)
{
    if ( collect[a-1] == "Suturday" )
    {
        Console.WriteLine("Выходной");
    }
    else if ( collect[a-1] == "Sunday" )
    {
        Console.WriteLine("Выходной");
    }
}
Console.WriteLine("Введите число от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Suturday", "Sunday"};

Weekend(array, n);
