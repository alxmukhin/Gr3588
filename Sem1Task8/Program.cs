Console.WriteLine("Введите число:");
string? inputLine = Console.ReadLine();
if(inputLine!=null)
{
     int number = int.Parse(inputLine);
     int index = 2;
     string outLine = string.Empty;
     if(number%2 == 0)
     {
        while(index <= number)
        {
            outLine = outLine + index + "  ";
            index = index + 2;
        }
     }
     else
     {
         while(index < number)
        {
            outLine = outLine + index + "  ";
            index = index + 2;
        }
     }
     Console.WriteLine(outLine);
}