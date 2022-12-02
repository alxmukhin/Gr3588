string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();

if(inputLine1!=null && inputLine2!=null && inputLine3!=null)
{
    int Number1 = int.Parse(inputLine1);
    int Number2 = int.Parse(inputLine2);
    int Number3 = int.Parse(inputLine3);
    int max = new();

    if(Number1 > Number2)
    {
        if(Number1 > Number3)
        {
            max = Number1;
        }
        else
        {
            max = Number3;
        }
    }
    else
    {
        if(Number2 > Number3)
        {
            max = Number2;
        }
        else
        {
            max = Number3;
        }
    }
    Console.WriteLine("Максимальное число из трех равно: " + max);
}