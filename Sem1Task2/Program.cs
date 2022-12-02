Console.WriteLine("Введите первое число:");
//read first number
string? inputLine1 = Console.ReadLine();                                               
Console.WriteLine("Введите второе число:");
//read second number
string? inputLine2 = Console.ReadLine();
//null safety check                                              
if(inputLine1!=null && inputLine2!=null)                                               
{
    //convert string into ineger
    int number1 = int.Parse(inputLine1);
    int number2 = int.Parse(inputLine2);
    //check if first number is greater than second
    if(number1 > number2)
    {
        //output result of check
        Console.WriteLine("Число " + number1 + " больше числа " + number2);
    }
    else
    {
        //check if first number and second number are equal
        if(number1 == number2)
        {
            //output result of check
            Console.WriteLine("Число " + number2 + " равно числу " + number1);
        }
        else
        {
            //output result of check
            Console.WriteLine("Число " + number2 + " больше числа " + number1);
        }
    }
}