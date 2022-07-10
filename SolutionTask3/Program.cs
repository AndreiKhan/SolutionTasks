// Показывает числа от -N до N
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int startNumber  = 1;

    string lineOutput = "0";

    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber * (-1) + ", " + lineOutput + ", " + startNumber;
        startNumber++;
    }

    Console.WriteLine(lineOutput);
}

// if (inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);

//     int startNumber  = (inputNumber * -1);

//     string lineOutput = "";                                  !Это вариант где шагов будет больше!

//     while (startNumber < inputNumber)
//     {
//         lineOutput = lineOutput + startNumber + ", ";
//         startNumber++;
//     }

//     lineOutput = lineOutput + inputNumber;

//     Console.WriteLine(lineOutput);
// }