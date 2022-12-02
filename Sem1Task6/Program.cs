Console.WriteLine("Введите число:");
//read number
string? inputLine = Console.ReadLine();
//null safety check
if(inputLine!=null)
{
    //convert string into integer
    int number = int.Parse(inputLine);
    //check if number is devisible by 2
    int remainder = number%2;
    //define if number is even or odd
    if (remainder==0)
    {
        //output result if number is even
        Console.WriteLine("Данное число является четным.");
    }
    else
    {
        //output result if number is odd
        Console.WriteLine("Данное число не является четным.");
    }
}