Console.WriteLine("Введите число:");
//read number
string? inputLine = Console.ReadLine();
//null safety check
if(inputLine!=null)
{
     //convert string into integer
     int number = int.Parse(inputLine);
     //define first even value
     int index = 2;
     //define string variable for storing output
     string outLine = string.Empty;
     //check if number is even or odd
     if(number%2 == 0)
     {
        //if number is even it will be last in output row, thus less than or equal operator is used
        while(index <= number)
        {
            //start collecting even numbers in a row
            outLine = outLine + index + "  ";
            //add two as only even values have to be recorded
            index = index + 2;
        }
     }
     else
     {
         //if number is odd it should not be in output row, thus less than operator is used
         while(index < number)
        {
            //start collecting even numbers in a row
            outLine = outLine + index + "  ";
            //add two as only even values have to be recorded
            index = index + 2;
        }
     }
     //output row with even numbers
     Console.WriteLine(outLine);
}