// read day number
string? inputLine = Console.ReadLine();
//null safety check
if(inputLine!=null)
{
    // // create new array
    // string[] dayWeek = new string[7];
    // // fill in array with day names
    // dayWeek[0] = "Monday";
    // dayWeek[1] = "Tuesday";
    // dayWeek[2] = "Wednesday";
    // dayWeek[3] = "Thursday";
    // dayWeek[4] = "Friday";
    // dayWeek[5] = "Saturday";
    // dayWeek[6] = "Sunday";
    // // convert string to integer
    int inputNumber = int.Parse(inputLine);
    // // find day name
    // string outDayOfWeek = dayWeek[inputNumber - 1];
   
    // string outDayOfWeek = string.Empty;
    // switch (inputNumber)
    // {
    //     case 1: outDayOfWeek = "Monday"; break;
    //     case 2: outDayOfWeek = "Tuesday"; break;
    //     case 3: outDayOfWeek = "Wednesday"; break;
    //     case 4: outDayOfWeek = "Thursday"; break;
    //     case 5: outDayOfWeek = "Friday"; break;
    //     case 6: outDayOfWeek = "Saturday"; break;
    //     case 7: outDayOfWeek = "Sunday"; break;
    //     default: outDayOfWeek = "Это не день недели!"; break;
    // }
    // // write result

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName.((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));

    Console.WriteLine(outDayOfWeek);
}