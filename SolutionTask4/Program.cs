// Находим последнее число из трехзначного
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    //int inputNumber = int.Parse(inputLine);               //Первый вариант через нахождение остатка
    //int outputNumber = inputNumber % 10;
    //Console.WriteLine(outputNumber);

    //string outputNumber = inputLine.Substring(2, 1);      //Второй вариант одной строкой
    //Console.WriteLine(outputNumber);
    
    char[] M = inputLine.ToCharArray();                     //Третий вариант через массив
    Console.WriteLine(M[2]);
}