Console.WriteLine("Введите номер четверти:");
int quarter = int.Parse(Console.ReadLine() ?? "0");

void XYrange(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("X>0 & Y>0");
        if (num == 2) Console.WriteLine("X>0 & Y<0");
        if (num == 3) Console.WriteLine("X<0 & Y<0");
        if (num == 4) Console.WriteLine("X<0 & Y>0");
    }
    else
    {
        Console.WriteLine("Это не номер четверти!");
    }
}

XYrange(quarter);