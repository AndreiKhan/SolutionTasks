//------------------Задача 6--------------------
//-----------Определение четного числа----------
//----------------------------------------------
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    //int inputNumber = int.Parse(inputLine);
    //
    // if(inputNumber % 2 == 0)
    // {
    //     Console.WriteLine(inputNumber + " - Четное число");                  //Первый вариант через if
    // }
    // else
    // {
    //     Console.WriteLine(inputNumber + " - Нечетное число");
    // }

    
    //Раскладываем число в массиве
    char[] M = inputLine.ToCharArray();
    //Берем число под последним индексом и проверяем четное ли оно
    if((M[M.Length - 1] % 2) == 0)
    {
        Console.WriteLine(inputLine + " - Четное число");                       //Второй вариант через массив и if
    }
    else
    {
        Console.WriteLine(inputLine + " - Нечетное число");
    }
}