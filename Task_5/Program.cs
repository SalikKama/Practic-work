int Chetvert(int X, int Y)
{
    int num = 0;
    if (X > 0 && Y > 0) num = 1;
    else if (X < 0 && Y > 0) num = 2;
    else if (X < 0 && Y < 0) num = 3;
    else num = 4;
    return num;
}

Console.WriteLine("Введите числа x, y не равные нулю:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int number = Chetvert(x, y);
Console.WriteLine($"Четверть номер: {number}");