//using method ReadData in order to get value which will pass palindrome test
int number = ReadData("Введите пятизначное число:");
//using methods PrintData tou output palindrome test result and method PalindromeTest in order to define if inserted value is palindrome or isn't
PrintData(number, PalindromeTest(number));

//ReadData method which will print input data request message & it's output is value inserted by the user
int ReadData(string message)
{
    //output request data message
    Console.WriteLine(message);
    //method return will be integer value received from inputed string by conversion, null safety check also is done here
    return int.Parse(Console.ReadLine() ?? "0");
}

//PalindroromeTest method performs if inserted value is palindrome or isn't, it's output is logical value 
bool PalindromeTest (int number)
{
    //create logical variable which will store test result
    bool testResult = false;
    //check if number is palindrome is performed by check of equality of first & fifth and second & fourth digits respectively, digits received by applying combinations of arithmetic operators
    if(number%10 == number/10000 && number%100/10 == number/1000%10)
    {
        //if condition described above fullfiled, palindrome test passed, and logical variable value ganged to True
        testResult = true;
    }
    else
    {
        //if condition described above is not fullfiled, palindrome test failed, and logical variable value remains False
        testResult = false;
    }
    //method return is logical vaue reflecting palindrome test result
    return testResult;
}

//PrintData method prints results of Palindrome test; number length check also included in this method
void PrintData (int number, bool testResult)
{
    //number lenght check is based on evaluation of its common logarithm value, which should be 4 or greater, but less than 5
    if(Math.Log10(number)>=4 && Math.Log10(number)<5)
    {
        //check result of palindrome test
        if(testResult == true)
        {
            //output for number succesfully passed palindrome test
            Console.WriteLine("Данное число является палиндромом.");
        }
        else
        {
            //output for number which failed palindrome test
            Console.WriteLine("Данное число не является палиндромом.");
        }
    }
    else
    {
        //output for number which is not 5 digits number
        Console.WriteLine("Введенное число не является пятизначным!");
    }
}