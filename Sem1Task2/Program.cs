Console.WriteLine("Введите первое число:");
string? inputLine1 = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string? inputLine2 = Console.ReadLine();
if(inputLine1!=null && inputLine2!=null)
{
    int Number1 = int.Parse(inputLine1);
    int Number2 = int.Parse(inputLine2);
    if(Number1 > Number2)
    {
        Console.WriteLine("Число " + Number1 + " больше числа " + Number2);
    }
    else
    {
        if(Number1 == Number2)
        {
            Console.WriteLine("Число " + Number2 + " равно числу " + Number1);
        }
        else
        {
            Console.WriteLine("Число " + Number2 + " больше числа " + Number1);
        }
    }
}