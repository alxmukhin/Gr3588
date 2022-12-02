Console.WriteLine("Введите первое число:");
//read first number
string? inputLine1 = Console.ReadLine();
Console.WriteLine("Введите второе число:");
//read second number
string? inputLine2 = Console.ReadLine();
Console.WriteLine("Введите третье число:");
//read third number
string? inputLine3 = Console.ReadLine();
//null safety check
if(inputLine1!=null && inputLine2!=null && inputLine3!=null)
{
    //convert string into integer
    int Number1 = int.Parse(inputLine1);
    int Number2 = int.Parse(inputLine2);
    int Number3 = int.Parse(inputLine3);
    //create variable which will store maximum value
    int max = new();
    //check if first umber is greater than second
    if(Number1 > Number2)
    {
        //check if first umber is greater than third
        if(Number1 > Number3)
        {
            //record maximum value
            max = Number1;
        }
        else
        {
            //record maximum value
            max = Number3;
        }
    }
    else
    {
        //check if second number is greater than third
        if(Number2 > Number3)
        {
            //record maximum value
            max = Number2;
        }
        else
        {
            //record maximum value
            max = Number3;
        }
    }
    //output maximum value
    Console.WriteLine("Максимальное число из трех равно: " + max);
}