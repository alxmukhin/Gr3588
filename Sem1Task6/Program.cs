Console.WriteLine("Введите число:");
string? inputLine = Console.ReadLine();
if(inputLine!=null)
{
    int number = int.Parse(inputLine);
    int remainder = number%2;
    if (remainder==0)
    {
        Console.WriteLine("Данное число является четным.");
    }
    else
    {
        Console.WriteLine("Данное число не является четным.");
    }
}
